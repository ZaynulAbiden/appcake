using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidesUIController : MonoBehaviour, IRecyclableScrollRectDataSource
{
    [Space]
    [SerializeField] private RecyclableScrollRect _recyclableScrollRect;
    [Space(10)]
    [SerializeField] private JsonDataContainer jsonDataContainer;


    [SerializeField]
    private List<GuidesInfo> _recievedData = new List<GuidesInfo>();
    [SerializeField]
    private List<GuidesInfo> _currentDisplayedData = new List<GuidesInfo>();

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
        for (int GuideIndex = 0; GuideIndex < jsonDataContainer.Guides.Count; GuideIndex++)
        {
            var guide = jsonDataContainer.Guides[GuideIndex];

            CreateCardData(guide, GuideIndex);


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


    private void CreateCardData(Guide hero, int itemIndex)
    {

        // Check if this card on Fav

        var guideinfo = new GuidesInfo();

        guideinfo.SetCardName(hero.GuideName);
        guideinfo.SetCardDescription(hero.GuideDescription);
        guideinfo.SetCardImagePath(hero.GuideImagePath);
        guideinfo.CardIndex = itemIndex;
        guideinfo.IsFav = hero.isFavorite;

        _recievedData.Add(guideinfo);
        _currentDisplayedData.Add(guideinfo);

    }


    public int GetItemCount()
    {
        return _currentDisplayedData.Count;
    }

    public void SetCell(ICell cell, int index)
    {
        var GuideCarditem = cell as CardUIBase;
        var GuideCardData = _currentDisplayedData[index];


        SetCardDataNOMM(GuideCarditem, GuideCardData);
    }

    private void SetCardDataNOMM(CardUIBase hearoCarditem, GuidesInfo guideCardData)
    {
        Debug.Log("Card " + guideCardData.CardIndex + "Name :  " + guideCardData.GetCardName());
        Debug.Log("Card " + guideCardData.CardIndex + " Description :  " + guideCardData.GetCardDescription());
        Debug.Log("Card " + guideCardData.CardIndex + " Image Path :  " + guideCardData.GetCardImagePath());
        hearoCarditem.SetCardName(guideCardData.GetCardName());
        hearoCarditem.SetCardDescription(guideCardData.GetCardDescription());
        hearoCarditem.SetCardImage(guideCardData.GetCardImagePath());
        hearoCarditem.CardIndex = guideCardData.CardIndex;

    }
}