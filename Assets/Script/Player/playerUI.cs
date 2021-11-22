using UnityEngine;
using UnityEngine.UI;

public class playerUI : MonoBehaviour
{
    /// <summary>プレイヤーを入れる</summary>
    [SerializeField] GameObject Player_mov;
    /// <summary>プレイヤーが当たった物の判定</summary>
    [SerializeField] int hit;
    /// <summary>ドアに当たった判定</summary>
    [SerializeField] private bool doorUI;
    /// <summary>プレイヤーのアイテムを保持</summary>
    [SerializeField] public bool boxUI, boxOC;
    /// <summary>プレイヤーのアイテムを保持</summary>
    [SerializeField] private bool ItemUI_Ch;
    /// <summary>ボックスのUIを保持</summary>
    [SerializeField] private GameObject ItemBox;
    PlayerMov pm;
    /// <summary>プレイヤーがカギを持っているか</summary>
    public bool Havekey;
    /// <summary>プレイヤーがどのボックスに当たったかどうか</summary>
    public float boxTe;
    /// <summary>プレイヤーの情報取得</summary>
    public GameObject player_Item;
    /// <summary>プレイヤーサポートテキスト</summary>
    public GameObject TextUI;
    /// <summary>プレイヤーのアイテムを保持</summary>
    public GameObject itemFolderUI;
    SlotGrit slotGrit;
    /// <summary>プレイヤーコントロースを保管</summary>
    PlayerControl PC;
    void Start()
    {
        Havekey = false;
        boxUI = false;
        boxOC = false;
        ItemUI_Ch = false;
        hit = 0;
        slotGrit = FindObjectOfType<SlotGrit>();
        Player_mov = GameObject.Find("Player");
        pm = FindObjectOfType<PlayerMov>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && boxOC == false)
        {
            Item();
        }
        Box_UI();
        PlayerControl PC = player_Item.GetComponent<PlayerControl>();
        boxTe = PC.te;
    }
    //item関連
    public void Item()
    {
        if (ItemUI_Ch == false)
        {
            ItemUI_Ch = true;
        }
        else if(ItemUI_Ch == true)
        {
            ItemUI_Ch = false;
        }
        Item_ch();
    }
    void Item_ch()
    {
        if (ItemUI_Ch == true)
        {
            box_tr();
            pm.mouse_O();
        }
        else if (ItemUI_Ch == false)
        {
            box_fa();
            pm.mouse_C();
        }
    }
    public void box_fa()
    {
        itemFolderUI.gameObject.SetActive(false);
    }
    public void box_tr()
    {
        itemFolderUI.gameObject.SetActive(true);
    }
    public void inBox_tr()
    {
        ItemBox.gameObject.SetActive(true);
    }
    public void outBox()
    {
        ItemBox.gameObject.SetActive(false);
    }
    //box関連
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
            ItemUI_Ch = true;
            pm.mouse_O();
            slotGrit.HitBox = true;
            slotGrit.BoxInventory();
        }
        else if (Input.GetKeyDown("space") && boxOC && hit == 1)
        {
            boxOC = false;
            ItemUI_Ch = false;
            slotGrit.HitBox = false;
            pm.mouse_C();
        }
        if (boxOC)
        {
            pm.speed = 0;
            Item_ch();
            inBox_tr();
        }
        else if (!boxOC)
        {
            pm.speed = 3;
            Item_ch();
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
        if (other.gameObject.tag == "keyDoor" && Havekey == true)
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
        if (col.gameObject.tag == "keyDoor")
        {
            doorUI = true;
            hit = 0;
        }
    }
}