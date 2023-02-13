using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsUIController : MonoBehaviour, IRecyclableScrollRectDataSource
{
    [Space]
    [SerializeField] private RecyclableScrollRect _recyclableScrollRect;
    [Space(10)]
    [SerializeField] private JsonDataContainer jsonDataContainer;


    [SerializeField]
    private List<TipsInfo> _recievedData = new List<TipsInfo>();
    [SerializeField]
    private List<TipsInfo> _currentDisplayedData = new List<TipsInfo>();

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
        for (int TipsCategory = 0; TipsCategory < jsonDataContainer.Tips.Count; TipsCategory++)
        {
            var tip = jsonDataContainer.Tips[TipsCategory];

            CreateCardData(tip, TipsCategory);


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


    private void CreateCardData(Tip tip, int itemIndex)
    {

        // Check if this card on Fav

        var tipsInfo = new TipsInfo();

        tipsInfo.SetCardName(tip.TipName);
        tipsInfo.SetCardDescription(tip.TipDescription);
        tipsInfo.SetCardImagePath(tip.TipImagePath);
        tipsInfo.CardIndex = itemIndex;
        tipsInfo.IsFav = tip.isFavorite;

        _recievedData.Add(tipsInfo);
        _currentDisplayedData.Add(tipsInfo);

    }


    public int GetItemCount()
    {
        return _currentDisplayedData.Count;
    }

    public void SetCell(ICell cell, int index)
    {
        var TipsCarditem = cell as CardUIBase;
        var HearoCardData = _currentDisplayedData[index];


        SetCardDataNOMM(TipsCarditem, HearoCardData);
    }

    private void SetCardDataNOMM(CardUIBase TipsCarditem, TipsInfo tipsCardData)
    {
        Debug.Log("Card " + tipsCardData.CardIndex + "Name :  " + tipsCardData.GetCardName());
        Debug.Log("Card " + tipsCardData.CardIndex + " Description :  " + tipsCardData.GetCardDescription());
        Debug.Log("Card " + tipsCardData.CardIndex + " Image Path :  " + tipsCardData.GetCardImagePath());
        TipsCarditem.SetCardName(tipsCardData.GetCardName());
        TipsCarditem.SetCardDescription(tipsCardData.GetCardDescription());
        TipsCarditem.SetCardImage(tipsCardData.GetCardImagePath());
        TipsCarditem.CardIndex = tipsCardData.CardIndex;

    }
}
