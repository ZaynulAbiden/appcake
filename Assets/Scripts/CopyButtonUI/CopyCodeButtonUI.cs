using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CopyCodeButtonUI : MonoBehaviour
{

    private const string _copiedstring = "Copied";
    private const string _copystring = "Copy";

    [SerializeField] private TextMeshProUGUI m_CopyTextMeshPro;

    public void ToogleCopyUI()
    {

        ShowCopiedUI();

    }

    private void ShowCopiedUI()
    {
        m_CopyTextMeshPro.text = _copiedstring;


    }


    public void ShowCopyUI()
    {

        m_CopyTextMeshPro.text = _copystring;

    }
}
