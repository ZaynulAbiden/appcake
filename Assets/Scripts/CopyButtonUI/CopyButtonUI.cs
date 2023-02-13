using System.Collections;
using TMPro;
using UnityEngine;

public class CopyButtonUI : MonoBehaviour
{

    private const string _copiedstring = "copied";
    private const string _copystring = "copy";

    [SerializeField] private TextMeshProUGUI m_CopyTextMeshPro;
    [SerializeField] private GameObject m_VectorOnCopy;
    [SerializeField] private GameObject m_VectorOnCopied;
    [SerializeField] private float waitTimeToCopyUI = 4f;

    public void ToogleCopyUI()
    {
        if (m_VectorOnCopy.activeInHierarchy)
            ShowCopiedUI();

    }

    private void ShowCopiedUI()
    {
        m_CopyTextMeshPro.text = _copiedstring;
        m_VectorOnCopy.SetActive(false);
        m_VectorOnCopied.SetActive(true);

    }


    public void ShowCopyUI()
    {

        m_CopyTextMeshPro.text = _copystring;
        m_VectorOnCopy.SetActive(true);
        m_VectorOnCopied.SetActive(false);
    }




}
