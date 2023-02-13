using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CardUIBase : MonoBehaviour, ICell
{
    public bool IsNew { get; set; }
    public bool IsFav { get; set; }
    [SerializeField] protected TextMeshProUGUI m_CardNameText;
    [SerializeField] protected TextMeshProUGUI m_CardDescriptionText;
    [SerializeField] protected GameObject m_NewTag;
    [SerializeField] protected FavoriteButton1336 m_CardFavButton;

    [SerializeField] protected RawImage m_CardImage;
    [SerializeField] protected Button m_CardButton;
    private int m_CardIndex;


    [SerializeField] private  DetailScreen DetailScreenPrefab;
    private void OnEnable()
    {
        m_CardButton.onClick.AddListener(OnClickCard);
    }

    public void SetFavoriteOnEnable(bool fav)
    {
        m_CardFavButton.SetFavoriteBtn(fav);
        IsFav = fav;
        ToggleNewTag(IsNew);
    }

    public void SetCardName(string cardName)
    {
        m_CardNameText.text = cardName;
    }

    public void SetCardDescription(string cardDescription)
    {
        m_CardDescriptionText.text = cardDescription;
    }

    public void ToggleNewTag(bool newTag)
    {
        m_NewTag.SetActive(newTag);
    }

    public void ToogleFav(bool newValue)
    {
        IsFav = newValue;
        JsonDataContainer.instance.Heroes[CardIndex].isFavorite = IsFav;
    }

    public string GetCardName()
    {
        return m_CardNameText.text;
    }

    public string GetCardDescription()
    {
        return m_CardDescriptionText.text;
    }

    public void SetCardImage(string imagePath)
    {
        StartCoroutine(SetCardTextureImageCoroutine(imagePath));
    }

    private IEnumerator SetCardTextureImageCoroutine(string imagePath)
    {
        yield return StartCoroutine(DownloaderHelper.DownloadFile_GMSFM(imagePath));
        m_CardImage.texture = DownloaderHelper.GetTextureAtPath_GMSFM(imagePath);
    }

    public Texture2D GetCardImage()
    {
        return m_CardImage.texture as Texture2D;
    }

    public int CardIndex
    {
        get { return m_CardIndex; }
        set { m_CardIndex = value; }
    }

    public virtual void OnClickCard()
    {
        Debug.Log("Show Detail Screen");
    }

    private void OnDisable()
    {
        m_CardButton.onClick.RemoveListener(OnClickCard);
        //Destroy(m_CardImage.texture);
    }
}
