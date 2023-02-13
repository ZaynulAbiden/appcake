using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ButtonFillterUI_GMSFM : MonoBehaviour
{
    public bool IsActive_GMSFM { get; private set; }

    [SerializeField] private Sprite activeSprite_GMSFM;

    [SerializeField] private Sprite unactiveSprite_GMSFM;

    [SerializeField] private Button _button_GMSFM;

    [SerializeField]
    private Image _btnImage_GMSFM;

    [SerializeField]
    private ButtonsUIFilterManager_GMSFM buttonsFilterManager_GMSFM;

    public void ToogleButton_GMSFM()
    {
        if (!buttonsFilterManager_GMSFM)
            buttonsFilterManager_GMSFM = GetComponentInParent<ButtonsUIFilterManager_GMSFM>();

        if (buttonsFilterManager_GMSFM)
            buttonsFilterManager_GMSFM.ChangeActiveButton_1336();

        if (!IsActive_GMSFM)
        {
            EnableButton_GMSFM();
        }

    }

    public void EnableButton_GMSFM()
    {
        _btnImage_GMSFM.sprite = activeSprite_GMSFM;

        IsActive_GMSFM = true;
    }

    public void DisableButton_GMSFM()
    {

        _btnImage_GMSFM.sprite = unactiveSprite_GMSFM;

        IsActive_GMSFM = false;

    }

}
