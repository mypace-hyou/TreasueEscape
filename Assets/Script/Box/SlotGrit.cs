using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGrit : MonoBehaviour
{
    private Item item;
    public Item MyItem { get => item; private set => item = value; }
    /// <summary>アイテムを入れるための空のオブジェクト</summary>
    [SerializeField]
    private GameObject slotPrefab;
    /// <summary>アイテムを入れないのダミーオブジェクト</summary>
    [SerializeField]
    private GameObject dummySlotPrefab;
    /// <summary>初期のボックス内に表示するスロットの数</summary>
    [SerializeField]private int slotNumber = 18;
    /// <summary>インベントリーのどこに表示させるナンバーを入れるList</summary>
    public List<int> inventoryLiet = new List<int>();
    /// <summary>全てのアイテム保管</summary>
    [SerializeField]
    private Item[] allItems;
    /// <summary>ボックス内のどこに表示するか番号</summary>
    private int boxItemNum = 0;
    /// <summary>アイテムを表示させるボックスナンバーを入れるList</summary>
    public List<int> BoxNumberList = new List<int>();
    /// <summary>全お宝の数</summary>
    [SerializeField] int totalTreasures;
    [SerializeField] GameObject player;
    PlayerControl pc;
    public bool HitBox = false;

    void Awake()
    {
        pc = player.GetComponent<PlayerControl>();
    }
    void Start()
    {
        for (int i = 0; i < 11;)//ボックス事に表示する場所を決める
        {
            int ran = Random.Range(0, totalTreasures);
            bool ch = BoxNumberList.Contains(ran);
            if (!ch)
            {
                BoxNumberList.Add(ran);
                i++;
            }
        }
        for (int i = 0; i < 11;)//どこに生成させる場所を決める
        {
            int ran = Random.Range(0, 17);
            bool ch = inventoryLiet.Contains(ran);
            if (!ch)
            {
                inventoryLiet.Add(ran);
                i++;
            }
        }
        //ボックスごとに表示が違う
    }
    public void BoxInventory()
    {
        if (HitBox == true)
        {
            foreach (Transform childTransform in this.gameObject.transform)
            {
                Destroy(childTransform.gameObject);
                HitBox = false;
            }
        }
        //ボックスの番号が一致したら特定のアイテムだけを表示させる
        if (pc.te != -1)
        {
            boxItemNum = BoxNumberList[pc.te];
        }
        int inventoryNum = inventoryLiet[boxItemNum];
        bool ch = BoxNumberList.Contains(pc.te);
        if (ch)
        {
            for (int i = 0; i < slotNumber; i++)
            { 
                bool jg = inventoryLiet.Contains(i);
                if (jg && i == inventoryNum)
                {
                    //スロット生成
                    GameObject slotObj = Instantiate(slotPrefab, this.transform);
                    //アイテム生成
                    Slot slot = slotObj.GetComponent<Slot>();
                    //アイテムセット
                    slot.SetItem(allItems[boxItemNum]);
                }
                else
                {
                    //スロット生成
                    Instantiate(dummySlotPrefab, this.transform);
                }
            }
        }
        else
        {
            for (int i = 0; i < slotNumber; i++)
            {
                //スロット生成
                Instantiate(dummySlotPrefab, this.transform);
            }
        }
        
    }
}
