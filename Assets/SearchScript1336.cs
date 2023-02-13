using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SearchScript1336 : MonoBehaviour
{
    public Transform menulist1336;

    public void UpdateList(TMP_InputField inputfield1336)
    {
        for(int i=0;i<menulist1336.childCount;i++)
        {
            if (menulist1336.GetChild(i).gameObject.name.Contains(inputfield1336.text.ToUpper()))
            {
                print(menulist1336.GetChild(i).gameObject.name);
                menulist1336.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                menulist1336.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
