using Plugins.Scripts.Dropbox;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;

public class JsonDownloaderManager1336 : MonoBehaviour
{
    [FormerlySerializedAs("codesJsonFilePath_SSZ")]
    [Space(10)]
    [SerializeField] private string codesJsonFilePath_1336;
    [FormerlySerializedAs("cheatsJsonFilePath_SSZ")]
    [Space(10)]
    [SerializeField] private string cheatsJsonFilePath_1336;
    [FormerlySerializedAs("tipsJsonFilePath_SSZ")]
    [Space(10)]
    [SerializeField] private string tipsJsonFilePath_1336;
    [FormerlySerializedAs("raidJsonFilePath_SSZ")]
    [Space(10)]
    [SerializeField] private string raidJsonFilePath_1336;
    [FormerlySerializedAs("modsJsonFilePath_SSZ")]
    [Space(10)]
    [SerializeField] private string modsJsonFilePath_1336;
    [FormerlySerializedAs("itemsJsonFilePath_SSZ")]
    [Space(10)]
    [SerializeField] private string itemsJsonFilePath_1336;
    [FormerlySerializedAs("heroesJsonFilePath_SSZ")]
    [Space(10)]
    [SerializeField] private string heroesJsonFilePath_1336;
    [FormerlySerializedAs("guidesJsonFilePath_SSZ")]
    [Space(10)]
    [SerializeField] private string guidesJsonFilePath_1336;
    [FormerlySerializedAs("MainMenuUI_SSZ")]
    [Space(10)]
    [SerializeField] private GameObject MainMenuUI_1336;
    [FormerlySerializedAs("loadingScreen1336UISsz")]
    [FormerlySerializedAs("LoadingScreenUI_SSZ")]
    [Space(10)]
    [SerializeField] private LoadingScreen_1336 loadingScreen1336;
    [FormerlySerializedAs("JsonDataContainer_SSZ")]
    [Space(10)]
    [SerializeField] private JsonDataContainer JsonDataContainer1336;
    private string _jasonData1336;
    public delegate void LoadJSONEvent_1336();
    public static event LoadJSONEvent_1336 OnJSONLoaded_1336;
    private void Start()
    {
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
        StartCoroutine(StartAsyncData_1336());
    }
    public virtual async Task StartAsync_1336() => await DropboxHelper.Initialize();
    public virtual IEnumerator StartAsyncData_1336()
    {
        var task_z1336 = StartAsync_1336();
        yield return new WaitUntil(() => task_z1336.IsCompleted);

        //Download Codes Json File
        yield return StartCoroutine(DownloadDataFromDropBox_z1336(codesJsonFilePath_1336));
        JsonDataContainer1336.PraseCodeData(_jasonData1336);
        //Download Cheats Json File
        yield return StartCoroutine(DownloadDataFromDropBox_z1336(cheatsJsonFilePath_1336));
        JsonDataContainer1336.PraseCheatsData(_jasonData1336);
        //Download Tips Json File
        yield return StartCoroutine(DownloadDataFromDropBox_z1336(tipsJsonFilePath_1336));
        JsonDataContainer1336.PraseTipsData(_jasonData1336);
        //Download Reservoir Raid Json File
        yield return StartCoroutine(DownloadDataFromDropBox_z1336(raidJsonFilePath_1336));
        JsonDataContainer1336.PraseReservoirRaidsData(_jasonData1336);
        //Download Mods Json File
        yield return StartCoroutine(DownloadDataFromDropBox_z1336(modsJsonFilePath_1336));
        JsonDataContainer1336.PraseModsData(_jasonData1336);
        //Download Items Json File
        yield return StartCoroutine(DownloadDataFromDropBox_z1336(itemsJsonFilePath_1336));
        JsonDataContainer1336.PraseItemData(_jasonData1336);
        //Download Heroes Json File
        yield return StartCoroutine(DownloadDataFromDropBox_z1336(heroesJsonFilePath_1336));
        JsonDataContainer1336.PraseHeroesData(_jasonData1336);
        //Download Guides Json File
        yield return StartCoroutine(DownloadDataFromDropBox_z1336(guidesJsonFilePath_1336));
        JsonDataContainer1336.PraseGuideData(_jasonData1336);
        yield return new WaitUntil(()=>loadingScreen1336.loadingComplete1336);
        Destroy(loadingScreen1336.gameObject); 
        MainMenuUI_1336.SetActive(true);
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
    }
    public virtual IEnumerator DownloadDataFromDropBox_z1336(string jsonFilepath_1336)
    {
        var task_1336 = DropboxHelper.GetRequestForFileDownload(jsonFilepath_1336);
        task_1336.downloadHandler = new DownloadHandlerBuffer();
        DownloadHandler handler_1336 = task_1336.downloadHandler;
        yield return task_1336.SendWebRequest();
        _jasonData1336 = handler_1336.text;
        Debug.Log(_jasonData1336);
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