using UnityEngine;
using UnityEngine.Networking;
using System.Collections;


public class APICaller : MonoBehaviour
{
    
   // private string apiUrl = "https://v1.apitest.us/go.json";
   // public UniWebView Uw;
   //// public GameObject Panel;
   // // Start is called before the first frame update
   // void Start()
   // {
   //     StartCoroutine(CallAPI());
   // }

   // IEnumerator CallAPI()
   // {
   //     using (UnityWebRequest webRequest = UnityWebRequest.Get(apiUrl))
   //     {
   //         // Send the request and wait for a response
   //         yield return webRequest.SendWebRequest();

   //         // Check for errors
   //         if (webRequest.isNetworkError || webRequest.isHttpError)
   //         {
   //             Debug.LogError("API request error: " + webRequest.error);
   //         }
   //         else
   //         {
               
   //             // Parse and use the response data here
   //             string responseData = webRequest.downloadHandler.text;
   //             Debug.LogError(responseData);
   //             if (responseData== "{\"isMaintenance\":true,\"Noti\":\"https://app.apitest.us/popup.html\"}")
   //             {
                   
   //                 // Panel.gameObject.SetActive(true);
   //                  Uw.Load("https://app.apitest.us/popup.html");
   //                  Uw.Show();
   //             }
   //             if (responseData == "{\"isMaintenance\":false,\"Noti\":\"https://app.apitest.us/popup.html\"}")
   //             {
   //                // Panel.gameObject.SetActive(false);
   //                 Uw.Stop();
                  
   //             }
   //             if (Uw.CanGoBack==true)
   //             {
   //                 Application.Quit();
   //             }
   //             // You can handle the response data as needed for your game
   //         }
   //     }
   // }
}
