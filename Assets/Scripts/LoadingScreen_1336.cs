using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class LoadingScreen_1336 : MonoBehaviour
{
    [FormerlySerializedAs("countTxt")] public Text count1336;
    [FormerlySerializedAs("loadingTimer")] public float loadingTimer1336 = 5;
    [FormerlySerializedAs("loadingComplete")] public bool loadingComplete1336;
    [FormerlySerializedAs("background")] public Sprite[] background1336;
    [FormerlySerializedAs("bg")] public GameObject bg1336;
    void Start()
    {
        bg1336.GetComponent<Image>().sprite = background1336[Random.Range(0,background1336.Length)];
        StartCoroutine(LoadScreen());
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
    }
    IEnumerator LoadScreen()
    {
        float time = 0;
        while (time < loadingTimer1336)
        {
            time += Time.deltaTime;
            float n = (time/loadingTimer1336)*100;
            count1336.text = (int)n+"%";
            yield return null;
        }
        loadingComplete1336 = true;
        
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
    }

    void z1336()
    {
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
    }
}
