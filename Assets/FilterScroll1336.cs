using UnityEngine;
using UnityEngine.UI;

public class FilterScroll1336 : MonoBehaviour
{
    [SerializeField] Image[] ButtonList1336;
    [SerializeField] private Sprite activeSprite1336;
    [SerializeField] private Sprite unactiveSprite1336;
    [SerializeField] ModsController controller;
    private void OnEnable()
    {
        ToggleSprite(0);
    }
    public void ShowAll1336(int i)
    {
        ToggleSprite(i);
        controller._favOnly = false;
        controller._newOnly = false;
        StartCoroutine(controller.ReloadDataCoroutine());
    }
    public void ShowFavorite1336(int i)
    {
        ToggleSprite(i);
        controller._favOnly = true;
        controller._newOnly = false;
        StartCoroutine(controller.ReloadDataCoroutine());
    }
    public void ShowNew1336(int i)
    {
        ToggleSprite(i);
        controller._newOnly = true;
        controller._favOnly = false;
        StartCoroutine(controller.ReloadDataCoroutine());
    }
    public void ToggleSprite(int i)
    {
        for(int j=0;j < ButtonList1336.Length;j++)
        {
            if (i == j)
                ButtonList1336[j].sprite = activeSprite1336;
            else
                ButtonList1336[j].sprite = unactiveSprite1336;
        }
    }
}
