using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingLeader : MonoBehaviour
{
    // Start is called before the first frame update
    public LeaderBoardController LBC;
    private void OnEnable()
    {
        LBC.SubmitScore();
        LBC.ShowScore();
        Debug.LogError("Hamid");
    }
}
