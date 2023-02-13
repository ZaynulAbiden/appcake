using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SearchBarUI : MonoBehaviour
{

    [SerializeField] private GameObject m_SearchBar;
    [SerializeField] private GameObject m_Header;
    [SerializeField] private TMP_InputField inputField1336;

    public ModsController controller;
    public void ShowSearchBar()
    {

        m_SearchBar.SetActive(true);
        m_Header.SetActive(false);
    }

    public void SearchFilterContent()
    {
        StartCoroutine(controller.ReloadDataCoroutine());
    }

    public void HideSearchBar()
    {
        m_SearchBar.SetActive(false);
        m_Header.SetActive(true);
    }


    public void ClearSearchPanel1336()
    {
        inputField1336.text = "";
    }
}
 