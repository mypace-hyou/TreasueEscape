using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text text;
    float time = 1;
    int count = 0;
    public GameObject button;
    PlayerMov pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PlayerMov>();
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        time -= Time.deltaTime;
        if (time <= 0)
        {
            count += 1;
            time = 0.3f; ;
        }
        switch (count)
        {
            case 0:
                text.text = "_";
                break;
            case 1:
                text.text = "d_";
                break;
            case 2:
                text.text = "だ_";
                break;
            case 3:
                text.text = "だs_";
                break;
            case 4:
                text.text = "だss_";
                break;
            case 5:
                text.text = "だssy_";
                break;
            case 6:
                text.text = "だっしゅ_";
                break;
            case 7:
                text.text = "だっしゅt_";
                break;
            case 8:
                text.text = "だっしゅつ_";
                break;
            case 9:
                text.text = "脱出_";
                break;
            case 10:
                text.text = "脱出s_";
                break;
            case 11:
                text.text = "脱出し_";
                break;
            case 12:
                text.text = "脱出しp_";
                break;
            case 13:
                text.text = "脱出しpp_";
                break;
            case 14:
                text.text = "脱出しっぱ_";
                break;
            case 15:
                text.text = "脱出しっぱい_";
                break;
            case 16:
                text.text = "脱出失敗";
                break;
            case 17:
                button.SetActive(true);
                break;
            default:
                break;
        }
    }
    public void LoadScen()
    {
        SceneManager.LoadScene("titol");
    }
}
