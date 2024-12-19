using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Implementation : MonoBehaviour
{
    int coins = 0;
    public Text coinsText;
    public Button intersttialButton;
    public Button rewardedButton;
    public GameObject GDPR_PANEL;
    /// <summary>
    /// Initialize the ads
    /// </summary>
    void Awake()
    {
        if (Advertisements.Instance.UserConsentWasSet() == false)
        {

            GDPR_PANEL.gameObject.SetActive(true);

        }
    }
    public void Yes()
    {
        Advertisements.Instance.SetUserConsent(true);
        GDPR_PANEL.gameObject.SetActive(false);
    }
    public void No()
    {
        Advertisements.Instance.SetUserConsent(false);
        GDPR_PANEL.gameObject.SetActive(false);
    }
    void Start()
    {

        Advertisements.Instance.Initialize();


        coinsText.text = coins.ToString();
       
    }

    /// <summary>
    /// Show banner, assigned from inspector
    /// </summary>
    public void ShawBanner()
    {
        Advertisements.Instance.ShowBanner(BannerPosition.BOTTOM,BannerType.SmartBanner);

       
    }

    public void HideBanner()
    {
        Advertisements.Instance.HideBanner();
    }


    /// <summary>
    /// Show Interstitial, assigned from inspector
    /// </summary>
    public void ShowInterstitial()
    {
        Advertisements.Instance.ShowInterstitial();
    }

    /// <summary>
    /// Show rewarded video, assigned from inspector
    /// </summary>
    public void ShowRewardedVideo()
    {
        Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
    }


    /// <summary>
    /// This is for testing purpose
    /// </summary>
    void Update()
    {
        if (Advertisements.Instance.IsInterstitialAvailable())
        {
            intersttialButton.interactable = true;
        }
        else
        {
            intersttialButton.interactable = false;
        }

        if (Advertisements.Instance.IsRewardVideoAvailable())
        {
            rewardedButton.interactable = true;
        }
        else
        {
            rewardedButton.interactable = false;
        }
    }

    private void CompleteMethod(bool completed)
    {
        if (completed)
        {
            coins += 100;
        }

        coinsText.text = coins.ToString();
    }
}
