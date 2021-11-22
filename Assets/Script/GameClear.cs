using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    /// <summary></summary>
    public Text text;
    /// <summary>演出用タイム</summary>
    float time = 1;
    /// <summary>演出に伴うカウント</summary>
    int count = 0;
    /// <summary>シーン切り替えようのボタン</summary>
    public GameObject button;
    PlayerMov pm;
    /// <summary>分を入れる</summary>
    public int minutes;
    /// <summary>秒を入れる</summary>
    public int secondsot;
    /// <summary>経過時間を表示するtext</summary>
    public Text Timetext;
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
                text.text = "脱出せ_";
                break;
            case 12:
                text.text = "脱出せい_";
                break;
            case 13:
                text.text = "脱出せいk_";
                break;
            case 14:
                text.text = "脱出せいこ_";
                break;
            case 15:
                text.text = "脱出せいこう_";
                break;
            case 16:
                text.text = "脱出成功";
                break;
            case 17:
                button.SetActive(true);
                minutes = gamemanager.StaticMinutes;
                secondsot = gamemanager.StaticSeconds;
                Timetext.text = "クリアタイム" + minutes + "分" + secondsot + "秒";
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
