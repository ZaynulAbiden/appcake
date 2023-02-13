using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddFavoriteButton : MonoBehaviour
{

    public bool IsFavorite_SSZ { get; private set; }

    private const string addtofavouritesString_SSZ = "Add to favourites";
    private const string addedtofavourites_SSZ = "Added to favourites";
    [SerializeField] private TextMeshProUGUI favoriteText_SSZ;
    [SerializeField] private Image favoriteButtonImage_SSZ;
    [SerializeField] private Sprite spriteFavoriteButtonImage_SSZ;
    [SerializeField] private Sprite spriteUnfavoriteButtonImage_SSZ;

    public void ToogleFavoiteUIState_SSZ()
    {
        #region Garbage Code

        while (false)
        {
            try
            {
                var Code_GGG_E_GMSFM = 1 + 1;
                Code_GGG_E_GMSFM += 1;
                Console.WriteLine(Code_GGG_E_GMSFM);
            }
            catch (System.Exception E_GMSFM)
            {
                Console.WriteLine(E_GMSFM);
                throw;
            }
        }

        #endregion

        if (IsFavorite_SSZ)
            UnfaveUIButton_SSZ();


        else
            FaveUIButton_SSZ();



    }

    public void FaveUIButton_SSZ()
    {
        #region Garbage Code

        while (false)
        {
            try
            {
                var Code_GGG_E_GMSFM = 1 + 1;
                Code_GGG_E_GMSFM += 1;
                Console.WriteLine(Code_GGG_E_GMSFM);
            }
            catch (System.Exception E_GMSFM)
            {
                Console.WriteLine(E_GMSFM);
                throw;
            }
        }

        #endregion


        favoriteButtonImage_SSZ.sprite = spriteFavoriteButtonImage_SSZ;
        favoriteText_SSZ.text = addedtofavourites_SSZ;
        IsFavorite_SSZ = true;
    }

    public void UnfaveUIButton_SSZ()
    {
        #region Garbage Code

        while (false)
        {
            try
            {
                var Code_GGG_E_GMSFM = 1 + 1;
                Code_GGG_E_GMSFM += 1;
                Console.WriteLine(Code_GGG_E_GMSFM);
            }
            catch (System.Exception E_GMSFM)
            {
                Console.WriteLine(E_GMSFM);
                throw;
            }
        }

        #endregion

        favoriteButtonImage_SSZ.sprite = spriteUnfavoriteButtonImage_SSZ;
        favoriteText_SSZ.text = addtofavouritesString_SSZ;
        IsFavorite_SSZ = false;
    }
}
