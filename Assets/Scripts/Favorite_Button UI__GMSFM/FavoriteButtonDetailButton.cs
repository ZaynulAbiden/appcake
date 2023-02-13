using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FavoriteButtonDetailButton : MonoBehaviour
{
    public bool IsFavorite_SSZ { get; private set; }


    [SerializeField] private Image favButtonImage_SSZ;
    [SerializeField] private Sprite spritefavButtonImage_SSZ;
    [SerializeField] private Sprite spriteunfavButtonImage_SSZ;



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


        favButtonImage_SSZ.sprite = spritefavButtonImage_SSZ;

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

        favButtonImage_SSZ.sprite = spriteunfavButtonImage_SSZ;
        IsFavorite_SSZ = false;
    }
}
