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
    public bool itemCH = false;
    public bool gateCH = false;
    public bool goleCH = false;
    public int ran;
    // Start is called before the first frame update
    void Start()
    {
        instanc = this;
        time = 60;
        playerControl = itemBag.GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        Timetext.text ="残り時間" +time.ToString("F0");
        //time -= Time.deltaTime;
        if (ItemCh < 5)
        {
            itemCH = false;
        }
        else if (ItemCh >= 5)
        {
            itemCH = true;
        } 
        if (time <= 0)
        {
            O_GameScene();
        }
        if (itemCH == true && gateCH == true && goleCH == true)
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
