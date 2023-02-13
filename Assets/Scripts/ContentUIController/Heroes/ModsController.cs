using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ModsController : MonoBehaviour, IRecyclableScrollRectDataSource
{
    [Space]
    [SerializeField] public RecyclableScrollRect _recyclableScrollRect;
    [Space(10)]
    [SerializeField] private JsonDataContainer jsonDataContainer;
    public  List<HerosInfo> _recievedData = new List<HerosInfo>();
    [SerializeField] private List<HerosInfo> _currentDisplayedData = new List<HerosInfo>();
    private bool _isScrollInitialized = false;
    [Space(10)][Header("Search Related Item")]
    public bool _favOnly;
    public bool _newOnly;
    public TMP_InputField inputField1336;

    public IEnumerator ReloadDataCoroutine()
    {
        _recievedData.Clear();
        _currentDisplayedData.Clear();
        yield return new WaitUntil(() => _recyclableScrollRect.gameObject.activeInHierarchy == true);
        _recyclableScrollRect.ReloadData();
        ProcessLoadedData(); 
    }
    private void OnEnable()
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

        for (int index = 0; index < jsonDataContainer.Heroes.Count; index++)
        {
            var data1336 = jsonDataContainer.Heroes[index];
            if ((_favOnly && !data1336.isFavorite) ||(_newOnly && !data1336.IsNew))
                return;
            if(data1336.HeroName.Contains(inputField1336.text))
                CreateCardData(data1336, index);
        }
    }

    public void InitializeScroll()
    {
        Debug.Log("Initializing Scroll");
        if (!_isScrollInitialized)
        {
            _isScrollInitialized = true;
            _recyclableScrollRect.Initialize(this);
        }
    }

    private void CreateCardData(Hero hero, int itemIndex)
    {
        var hearoinfo = new HerosInfo();
        hearoinfo.SetCardName(hero.HeroName);
        hearoinfo.SetCardDescription(hero.HeroDescription);
        hearoinfo.SetCardImagePath(hero.HeroImagePath);
        hearoinfo.CardIndex = itemIndex;
        hearoinfo.IsFav = hero.isFavorite;
        hearoinfo.IsNew = hero.IsNew;
        _recievedData.Add(hearoinfo);
        _currentDisplayedData.Add(hearoinfo);
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

    private void SetCardDataNOMM(CardUIBase hearoCarditem, HerosInfo hearoCardData)
    {
        hearoCarditem.SetCardName(hearoCardData.GetCardName());
        hearoCarditem.SetCardDescription(hearoCardData.GetCardDescription());
        hearoCarditem.SetCardImage(hearoCardData.GetCardImagePath());
        hearoCarditem.CardIndex = hearoCardData.CardIndex;
        hearoCarditem.IsFav = hearoCardData.IsFav;
        hearoCarditem.IsNew = hearoCardData.IsNew;
        hearoCarditem.SetFavoriteOnEnable(hearoCardData.IsFav);
        
    }
}   