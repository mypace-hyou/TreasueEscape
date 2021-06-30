using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Titol : MonoBehaviour
{
    [Header("0は何もしてない,1はエンターが当たっている,2はアニメーション中")]
    public bool OpenLetterCH = false;
    [SerializeField] GameObject TitolObj;
    [SerializeField] GameObject textLook;
    [SerializeField] GameObject Crad;
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
        Crad.SetActive(true);
        textLook.SetActive(false);
        TitolObj.SetActive(false);
    }
    public void CloseLetter()
    {
        OpenLetterCH = false;
        TitolObj.SetActive(true);
    }
    public void LoadScen()
    {
        if (Input.GetMouseButtonDown(0) && OpenLetterCH == true)
        {
            SceneManager.LoadScene("ExperimentScene");
        }
    }
}
