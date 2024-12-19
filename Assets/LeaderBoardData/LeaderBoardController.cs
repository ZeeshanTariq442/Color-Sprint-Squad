using UnityEngine;
using UnityEngine.UI;
using LootLocker.Requests;
public class LeaderBoardController : MonoBehaviour
{
    public Text PlayerScore;
    public Text MemberId;
    public int ID;
    int MaxScore = 100;
    public Text[] Entries;
    public Text[] name;
    private void OnEnable()
    {

    }

    public void Start()
    {

        bool done = false;
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (response.success)
            {
                Debug.LogError("Player was logged in ");
                // PlayerPrefs.SetString("PlayerID", response.player_id.ToString());
                done = true;
            }
            else
            {
                Debug.LogError("Could Not Start Session");
                done = true;
            }

        });


        //LootLockerSDKManager.StartSession("player", (response) =>
        // {
        //     if (response.success)
        //     {
        //         Debug.LogError("Success");
        //     }
        //     else
        //     {
        //         Debug.LogError("Failed");
        //     }


        // });
    }
    private void Update()
    {
        MemberId.text = PlayerPrefs.GetString("Username");
        PlayerScore.text = PlayerPrefs.GetInt("score", 0).ToString();
    }
    public void ShowScore()
    {
        LootLockerSDKManager.GetScoreList(ID, MaxScore, (response) =>
        {
            if (response.success)
            {
                LootLockerLeaderboardMember[] score = response.items;
                LootLockerLeaderboardMember[] Name = response.items;
                for (int i = 0; i < score.Length; i++)
                {
                    Entries[i].text = (score[i].rank + ".    " + score[i].score);
                }
                for (int i = 0; i < Name.Length; i++)
                {
                    //name[i].text = PlayerPrefs.GetString("Username").ToString();
                    name[i].text = (Name[i].player + "" + Name[i].member_id);
                    //  name[i].text = MemberId.text;

                }
                if (score.Length < MaxScore)
                {
                    for (int i = score.Length; i < MaxScore; i++)
                    {
                        Entries[i].text = (i + 1).ToString() + ".";
                    }

                }
            }
            else
            {
                Debug.LogError("Failed");
            }
        });
    }
    public void SubmitScore()
    {
        LootLockerSDKManager.SubmitScore(MemberId.text, int.Parse(PlayerScore.text), ID, (response) =>
        {
            if (response.success)
            {
                Debug.LogError("Success");
            }
            else
            {
                Debug.LogError("Failed");
            }

        });
    }
}
