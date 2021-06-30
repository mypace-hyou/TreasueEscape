using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Titol : MonoBehaviour
{
    [Header("0は何もしてない,1はエンターが当たっている")]
    [SerializeField]bool OpenLetterCH = false;
    [SerializeField] GameObject TitolObj;
    [SerializeField] GameObject textLook;
    /// <summary>EvevtTrigerのスクリプト入れる</summary>
    public Sprite[] Sprit_UI;
    public void event_Enter()
    {
        GetComponent<Image>().sprite = Sprit_UI[1];
        textLook.SetActive(true);
    }
    public void event_Exit()
    {
        if (OpenLetterCH == false)
        {
            GetComponent<Image>().sprite = Sprit_UI[0];
            textLook.SetActive(false);
        }
    }
    public void openLetter()
    {
        OpenLetterCH = true;
        TitolObj.SetActive(true);
    }
    public void CloseLetter()
    {
        OpenLetterCH = false;
        TitolObj.SetActive(false);
    }
    public void LoadScen()
    {
        if (Input.GetMouseButtonDown(0) && OpenLetterCH == true)
        {
            SceneManager.LoadScene("ExperimentScene");
        }
    }
}
