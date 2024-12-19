using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Namesave : MonoBehaviour
{
    public string thename;
    public InputField InputField;
    public Text textdsiplay;
    public GameObject namepanel;
    int check;


    private void Awake()
    {
        if (PlayerPrefs.GetInt("name",0)==1)
        {
            namepanel.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("name", 0) == 0)
        {
            namepanel.gameObject.SetActive(true);
        }
        PlayerPrefs.GetInt("User");

        textdsiplay.text = PlayerPrefs.GetString("Username");
    }
    public void storename()
    {

             int checker = InputField.text.Length;
             Debug.LogError(checker);
        if (checker>0)
        {
            thename = InputField.text;
            textdsiplay.GetComponent<Text>().text = thename;
            namepanel.gameObject.SetActive(false);
            PlayerPrefs.SetInt("name", 1);

            PlayerPrefs.SetString("Username", textdsiplay.text);

        }
           
        
       
          
        
       
        
        
    }
}
