using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HerosInfo
{
    public bool IsNew { get; set; }
    public bool IsFav { get; set; }

    private string m_CardNameText;
    private string m_CardDescriptionText;
    private string m_CardImagePath;
    private int m_CardIndex;

    public HerosInfo()
    {
    }

    public void SetCardName(string cardName)
    {
        m_CardNameText = cardName;
    }

    public void SetCardDescription(string cardDescription)
    {
        m_CardDescriptionText = cardDescription;
    }


    public string GetCardName()
    {
        return m_CardNameText;
    }

    public string GetCardDescription()
    {
        return m_CardDescriptionText;
    }

    public void SetCardImagePath(string imagePath)
    {
        m_CardImagePath = imagePath;
    }

    public string GetCardImagePath()
    {
        return m_CardImagePath;
    }

    public int CardIndex
    {
        get { return m_CardIndex; }
        set { m_CardIndex = value; }
    }
}
