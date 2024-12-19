using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adscallers : MonoBehaviour
{
    private void OnEnable()
    {
        Advertisements.Instance.ShowInterstitial();
    }
}
