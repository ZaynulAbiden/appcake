using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(RectTransform))]
public class UIBottomChanger1336 : MonoBehaviour
{
    [FormerlySerializedAs("_amountNOMM")] [SerializeField] private float _amount1336 = 130f;
    [FormerlySerializedAs("_originalValueNOMM")] [SerializeField] private float _originalValue1336 = 0f;

    private RectTransform _rect1336;

    private void OnEnable()
    {
        if (_rect1336 == null)
            _rect1336 = GetComponent<RectTransform>();
        
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
    }
}

public static class RectTransformExtensions1336
{
    public static void SetLeft1336(this RectTransform rt, float left)
    {
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
        rt.offsetMin = new Vector2(left, rt.offsetMin.y);
    }

    public static void SetRight1336(this RectTransform rt, float right)
    {
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
        rt.offsetMax = new Vector2(-right, rt.offsetMax.y);
    }

    public static void SetTop1336(this RectTransform rt, float top)
    {
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
        rt.offsetMax = new Vector2(rt.offsetMax.x, -top);
    }

    public static void SetBottom1336(this RectTransform rt, float bottom)
    {
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
        rt.offsetMin = new Vector2(rt.offsetMin.x, bottom);
    }

    public static void SetHeight1336(this RectTransform rt1336,float height1336)
    {
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
        rt1336.sizeDelta = new Vector2(rt1336.sizeDelta.x, height1336);
    }

    public static void ShowChild1336(this Transform tran1336, int childIndex1336)
    {
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
        for (int i = 0; i < tran1336.childCount; i++)
        {
            var childNOMM = tran1336.GetChild(i);

            if (i == childIndex1336)
            {
                childNOMM.gameObject.SetActive(true);
            }
            else
            {
                childNOMM.gameObject.SetActive(false);
            }
        }
    }
    public static void DestroyChild1336(this Transform tran1336,int childIndex1336)
    {
        #region z1336
        if (false)
        {   
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
            while(false){if(true){while(false){if(false){}}}}
        }   
        #endregion
        try
        {
            var childNOMM = tran1336.GetChild(childIndex1336);

            if (childNOMM != null)
                MonoBehaviour.Destroy(childNOMM.gameObject);
        }
        catch (Exception ex)
        {
            Debug.Log($"You no child found : {ex}");
        }
    }
}
