using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class GuidesInfo 
{
    public bool IsNew { get; set; }
    public bool IsFav { get; set; }

    private string m_CardNameText;
    private string m_CardDescriptionText;
    private string m_CardImagePath;
    private int m_CardIndex;

    public GuidesInfo()
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
