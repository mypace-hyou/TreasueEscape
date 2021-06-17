using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGrit : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;
    
    private int slotNumber = 28;//初期のボックス内に表示するスロットの数
    List<int> itemHaveLiet = new List<int>();

    [SerializeField]
    private Item[] allItems;
    private int ItemImageNum = 0;
    //GameObject slotObj;
    //Slot slot;

    public List<int> BoxNumberList = new List<int>();
    List<Item> ImageList = new List<Item>();
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
            int ran = Random.Range(0, 20);
            bool ch = BoxNumberList.Contains(ran);
            if (!ch)
            {
                Debug.Log(ran);
                BoxNumberList.Add(ran);
                i++;
            }
        }
        for (int i = 0; i < 11;)//どこに生成させる場所を決める
        {
            int ran = Random.Range(0, 29);
            bool ch = itemHaveLiet.Contains(ran);
            if (!ch)
            {
                itemHaveLiet.Add(ran);
                i++;
            }
        }
        for (int i = 0; i < slotNumber; i++)
        {
            //スロット生成
            GameObject slotObj = Instantiate(slotPrefab, this.transform);
            //アイテム生成
            Slot slot = slotObj.GetComponent<Slot>();

            bool jg = itemHaveLiet.Contains(i);
            if (jg && ItemImageNum < allItems.Length)
            {
                //アイテムセット
                slot.SetItem(allItems[ItemImageNum]);
                ImageList.Add(allItems[ItemImageNum]);
                ItemImageNum++;
            }
            else
            {
                slot.SetItem(null);
                ImageList.Add(null);
            }
        }
        //ボックスごとに表示が違う
    }
    void Update()
    {
        //if (HitBox == true)
        //{
        //    BoxInventory();
        //}
    }
    public 
    void BoxInventory()
    {
        //ボックスの番号が一致したら特定のアイテムだけを表示させる
        //ボックスの番号が一致しなかったらnullを返す
        bool ch = BoxNumberList.Contains(pc.te);
        if (ch)
        {
            for (int i = 0; i < slotNumber; i++)
            {
                //アイテム生成
                Slot slot = FindObjectOfType<Slot>();
                bool jg = itemHaveLiet.Contains(i);
                if (jg && ItemImageNum < allItems.Length && ItemImageNum == pc.te)
                {
                    //アイテムセット
                    slot.SetItem(allItems[ItemImageNum]);
                }
                else
                {
                    slot.SetItem(null);
                    ItemImageNum++;
                }
            }
            HitBox = false;
        }
        else
        {
            for (int i = 0; i < slotNumber; i++)
            {
                //アイテム生成
                Slot slot = FindObjectOfType<Slot>();
                slot.SetItem(null);
            }
            HitBox = false;
        }
        
    }

}
