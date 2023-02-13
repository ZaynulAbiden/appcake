using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public bool IsNew { get; set; }

    public bool IsFav { get; set; }

    [SerializeField] protected TextMeshProUGUI m_CardNameText;
    [SerializeField] protected TextMeshProUGUI m_CardDescriptionText;
    [SerializeField] protected GameObject m_NewTag;
    [SerializeField] protected  AddFavoriteButton AddFavoriteButton;
    [SerializeField] protected RawImage m_CardImage;
    [SerializeField] protected Button m_CardButton;


    private int m_CardIndex;

    private void OnEnable()
    {
        m_CardButton.onClick.AddListener(OnClickCard);
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

    public void ToogleFav(bool isFav)
    {
        throw new System.NotImplementedException();
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

    public void OnClickCard()
    {
        Debug.Log("Show Code Card Detail Screen");
    }
}
