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
    public int ItemCh;
    /// <summary>鍵を持っているか</summary>
    public bool keyHaveCH = false;
    /// <summary>ゴールできる条件がそろったか</summary>
    public bool goleCH = false;
    // Start is called before the first frame update
    void Start()
    {
        instanc = this;
        time = 100;
        playerControl = itemBag.GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        Timetext.text ="残り時間" +time.ToString("F0");
        //time -= Time.deltaTime;
        if (time <= 0)
        {
            O_GameScene();
        }
        if (keyHaveCH == true && goleCH == true)
        {
            C_GameScene();
        }
    }
    public void C_GameScene()
    {
        SceneManager.LoadScene("GameClear");
    }
    public void O_GameScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}
