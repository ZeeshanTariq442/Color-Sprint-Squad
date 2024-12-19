using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Advertisements.Advertisement;

public class MainCanvas : MonoBehaviour
{
    int levelNo;
    public Text txt;
    public void PlayGame()
    {
       
        levelNo = PlayerPrefs.GetInt("Level", 1);
        SceneManager.LoadScene(levelNo);
    }
    
    private void Update()
    {
        txt.text = PlayerPrefs.GetInt("score", 0).ToString();
    }
    public void rateus()
    {
#if UNITY_ANDROID
        Application.OpenURL("market://details?id=com.teegalayashwanthreddy.colorsprintsquad");
#elif UNITY_IPHONE
Application.OpenURL("itms-apps://itunes.apple.com/app/");
#endif
    }
}
