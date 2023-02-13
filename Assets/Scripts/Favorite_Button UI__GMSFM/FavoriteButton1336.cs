using System;
using UnityEngine;
using UnityEngine.UI;
public class FavoriteButton1336 : MonoBehaviour
{
    public bool IsFavorite1336 { get; private set; } = false;
    [SerializeField] public Image favoVectorImage_GMSFM;
    [SerializeField] public Sprite favoSprite_GMSFM;
    [SerializeField] public Sprite unfavSprite_GMSFM;
    [SerializeField] public CardUIBase card;

    public void ToogleFavoiteUIState_GMSFM()
    {
        IsFavorite1336 = !IsFavorite1336;
        card.ToogleFav(IsFavorite1336);
        SetFavoriteBtn(IsFavorite1336);
    }

    public void SetFavoriteBtn(bool favTrue)
    {
        if (favTrue) 
           favoVectorImage_GMSFM.sprite = favoSprite_GMSFM;
        else
            favoVectorImage_GMSFM.sprite = unfavSprite_GMSFM;
    }
}
