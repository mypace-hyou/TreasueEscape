using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instanc { get; private set; }
    PlayerControl playerControl;
    public GameObject itemBag;
    int judge = 0;
    public Text Timetext;
    public float time;
    float minutes;
    public int ItemCh;
    /// <summary>鍵を持っているか</summary>
    public bool keyHaveCH = false;
    /// <summary>ゴールできる条件がそろったか</summary>
    public bool goleCH = false;
    public bool gameStartCh = false;

    public static float StaticMinutes;
    public static float StaticSeconds;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        instanc = this;
        time = 0;
        playerControl = itemBag.GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStartCh == true)
        {
            Timetext.text = "開始" + minutes + "分" + time.ToString("F0") + "秒";
            time += Time.deltaTime;
            if (time >= 59.5f)
            {
                minutes += 1;
                time = 0;
            }
            if (keyHaveCH == true && goleCH == true)
            {
                gameStartCh = false;
                StaticMinutes = minutes;
                StaticSeconds = time;
                C_GameScene();
            }
        }
    }
    public void C_GameScene()
    {
        SceneManager.LoadScene("GameClear");
    }
}
