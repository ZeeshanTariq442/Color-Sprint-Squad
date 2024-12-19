using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AdController : MonoBehaviour
{
    public static AdController instance;
  
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        Advertisements.Instance.Initialize();
        
    }


    public void ShowAds(UnityAction action )
    {
        Advertisements.Instance.ShowInterstitial(action);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
