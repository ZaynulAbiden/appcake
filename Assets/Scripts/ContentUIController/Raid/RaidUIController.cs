using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaidUIController : MonoBehaviour, IRecyclableScrollRectDataSource
{
    [Space]
    [SerializeField] private RecyclableScrollRect _recyclableScrollRect;
    [Space(10)]
    [SerializeField] private JsonDataContainer jsonDataContainer;


    [SerializeField]
    private List<RaidInfo> _recievedData = new List<RaidInfo>();
    [SerializeField]
    private List<RaidInfo> _currentDisplayedData = new List<RaidInfo>();

    private bool _isScrollInitialized = false;

    private IEnumerator ReloadDataCoroutine()
    {
        yield return new WaitUntil(() => _recyclableScrollRect.gameObject.activeInHierarchy == true);
        _recyclableScrollRect.ReloadData();

        ProcessLoadedData();


    }

    private void OnEnable()
    {
        HandleContent();
    }


    public void HandleContent()
    {
        StartCoroutine(ReloadDataCoroutine());


    }


    public void ProcessLoadedData()
    {
        Debug.Log("Processing Data ");

        if (_recyclableScrollRect.IsActive() && !_isScrollInitialized)
        {
            InitializeScroll();
        }

        //Looping the Maps Categories
        for (int RaidCategory = 0; RaidCategory < jsonDataContainer.ReservoirRaids.Count; RaidCategory++)
        {
            var raid = jsonDataContainer.ReservoirRaids[RaidCategory];

            CreateCardData(raid, RaidCategory);


        }


    }


    public void InitializeScroll()
    {
        Debug.Log("Initializing Scroll NOMM");
        if (!_isScrollInitialized)
        {
            _isScrollInitialized = true;
            _recyclableScrollRect.Initialize(this);
        }


    }


    private void CreateCardData(ReservoirRaid raid, int itemIndex)
    {

        // Check if this card on Fav

        var raidinfo = new RaidInfo();

        raidinfo.SetCardName(raid.ReservoirRaidName);
        raidinfo.SetCardDescription(raid.ReservoirRaidDescription);
        raidinfo.SetCardImagePath(raid.ReservoirRaidImagePath);
        raidinfo.CardIndex = itemIndex;
        raidinfo.IsFav = raid.isFavorite;

        _recievedData.Add(raidinfo);
        _currentDisplayedData.Add(raidinfo);

    }


    public int GetItemCount()
    {
        return _currentDisplayedData.Count;
    }

    public void SetCell(ICell cell, int index)
    {
        var HearoCarditem = cell as CardUIBase;
        var HearoCardData = _currentDisplayedData[index];


        SetCardDataNOMM(HearoCarditem, HearoCardData);
    }

    private void SetCardDataNOMM(CardUIBase raidCarditem, RaidInfo raidCardData)
    {
        Debug.Log("Card " + raidCardData.CardIndex + "Name :  " + raidCardData.GetCardName());
        Debug.Log("Card " + raidCardData.CardIndex + " Description :  " + raidCardData.GetCardDescription());
        Debug.Log("Card " + raidCardData.CardIndex + " Image Path :  " + raidCardData.GetCardImagePath());
        raidCarditem.SetCardName(raidCardData.GetCardName());
        raidCarditem.SetCardDescription(raidCardData.GetCardDescription());
        raidCarditem.SetCardImage(raidCardData.GetCardImagePath());
        raidCarditem.CardIndex = raidCardData.CardIndex;

    }
}
