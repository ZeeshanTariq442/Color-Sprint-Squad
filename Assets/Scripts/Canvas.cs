﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Canvas : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public GameObject Privacy_Policy;
    int levelNo;
    public static Canvas instance;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        levelNo = SceneManager.GetActiveScene().buildIndex;

        levelText.text = "Level " + levelNo.ToString();
        Privacy_Policy.SetActive(false);
    }

    public void NextLevel()
    {
        levelNo++;
        if(levelNo > 50)
        {
            levelNo = 1;
        }
        PlayerPrefs.SetInt("Level", levelNo);
        SceneManager.LoadScene(levelNo);
        if (AdManager.instance)
            AdManager.instance.ShowAd();

    }

    public void Reload()
    {
        SceneManager.LoadScene(levelNo);
        if (AdManager.instance)
            AdManager.instance.ShowAd();

    }
    public void Home()
    {
        SceneManager.LoadScene("1. Main scene");
        Time.timeScale = 1.0f;
    }
    public void PrivacyPolicy()
    {
        Application.OpenURL("");
    }
    public void Activate_Privacy_Policy()
    {
        Privacy_Policy.SetActive(true);
    }
    public void deactivate_PP()
    {
        Privacy_Policy.SetActive(false);
    }
}