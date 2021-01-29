using UnityEngine;
using UnityEngine.UI;

public class playerUI : MonoBehaviour
{
    public GameObject[] test;
    [SerializeField] GameObject Player_mov;
    [SerializeField] int hit;
    [SerializeField] private bool doorUI;
    [SerializeField] public bool boxUI, boxOC;
    [SerializeField] private GameObject ItemBox_tr, ItemBox_fa,ItemUI;
    public float boxRd;
    public float boxTe;
    public GameObject player_Item;
    public GameObject box_Item;
    public GameObject TextUI;
    void Start()
    {
        boxUI = false;
        boxOC = false;
        hit = 0;
        Player_mov = GameObject.Find("Player");
    }
    void Update()
    {
        Box_UI();
        gamemanager GM = box_Item.GetComponent<gamemanager>();
        boxRd = GM.Ram_Treasure;
        PlayerControl PC = player_Item.GetComponent<PlayerControl>();
        boxTe = PC.te;
    }
    public void inBox_tr()
    {
        ItemBox_tr.gameObject.SetActive(true);
        ItemUI.gameObject.SetActive(true);
    }
    public void inBox_fa()
    {
        ItemBox_fa.gameObject.SetActive(true);
    }
    public void outBox()
    {
        ItemBox_tr.gameObject.SetActive(false);
        ItemBox_fa.gameObject.SetActive(false);
    }
    public void Box_UI()
    {
        PlayerMov pm = GetComponent<PlayerMov>();
        if (boxUI && hit == 1 || doorUI && hit == 2)
        {
            TextUI.gameObject.SetActive(true);
        }
        else if (!boxUI && hit == 0 || !doorUI && hit == 0)
        {
            TextUI.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown("space") && !boxOC && hit == 1)
        {
            boxOC = true;
        }
        else if (Input.GetKeyDown("space") && boxOC && hit == 1)
        {
            boxOC = false;
        }
        if (boxOC)
        {
            pm.speed = 0;
            if (boxRd == boxTe)
            {
                inBox_tr();
            }
            else if (boxRd != boxTe)
            {
                inBox_fa();
            }
        }
        else if (!boxOC)
        {
            pm.speed = 6;
            outBox();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Box")
        {
            boxUI = true;
            hit = 1;
        }
        if (other.gameObject.tag == "Door")
        {
            doorUI = true;
            hit = 2;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Box")
        {
            boxUI = false;
            hit = 0;
        }
        if (col.gameObject.tag == "Door")
        {
            doorUI = true;
            hit = 0;
        }
    }
}