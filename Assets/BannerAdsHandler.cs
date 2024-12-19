using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerAdsHandler : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        Advertisements.Instance.ShowBanner(BannerPosition.BOTTOM);
    }


}
