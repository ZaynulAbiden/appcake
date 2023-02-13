using System;
using UnityEngine;


public class ButtonsUIFilterManager_GMSFM : MonoBehaviour
{
    [SerializeField]
    private ButtonFillterUI_GMSFM[] buttons_1336;
    [SerializeField] private bool ActiveOnEnable_1336 = true;
            
    private void OnEnable()
    {       
        if (ActiveOnEnable_1336)
        {   
            ChangeActiveButton_1336();
            if (buttons_1336.Length == 0)
            {
                buttons_1336 = GetComponentsInChildren<ButtonFillterUI_GMSFM>();
            }
            buttons_1336[0].EnableButton_GMSFM();
        }   
    }       
            
    public void ChangeActiveButton_1336()
    {       
        foreach (var button_GMSFM in buttons_1336)
        {   
            if (button_GMSFM.IsActive_GMSFM)
            {
                button_GMSFM.DisableButton_GMSFM();
                break;
            }
        }
    }

    public void TurnOffAllButton_1336()
    {       
        foreach (var button_GMSFM in buttons_1336)
            button_GMSFM.DisableButton_GMSFM();
    }       
}
