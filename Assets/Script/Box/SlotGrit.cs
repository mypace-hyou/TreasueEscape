using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGrit : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;
    /// <summary>初期のボックス内に表示するスロットの数</summary>
    private int slotNumber = 28;
    /// <summary>インベントリーのどこに表示させるナンバーを入れるList</summary>
    public List<int> inventoryLiet = new List<int>();

    [SerializeField]
    private Item[] allItems;
    /// <summary></summary>
    private int boxItemNum = 0;
    ///// <summary>アイテムを表示させるボックスナンバーを入れるList</summary>
    public List<int> BoxNumberList = new List<int>();
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
            int ran = Random.Range(0, 11);
            bool ch = BoxNumberList.Contains(ran);
            if (!ch)
            {
                BoxNumberList.Add(ran);
                i++;
            }
        }
        for (int i = 0; i < 11;)//どこに生成させる場所を決める
        {
            int ran = Random.Range(0, 29);
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
                //ItemImageNum = 0;
            }
        }
        //ボックスの番号が一致したら特定のアイテムだけを表示させる
        //ボックスの番号が一致しなかったらnullを返すF
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
                //スロット生成
                GameObject slotObj = Instantiate(slotPrefab, this.transform);
                //アイテム生成
                Slot slot = slotObj.GetComponent<Slot>();
                bool jg = inventoryLiet.Contains(i);
                if (jg && i == inventoryNum/* && ItemImageNum < allItems.Length*/)
                {
                    //アイテムセット
                    slot.SetItem(allItems[boxItemNum]);
                }
                else
                {
                    slot.SetItem(null);
                }
            }
        }
        else
        {
            for (int i = 0; i < slotNumber; i++)
            {
                //スロット生成
                GameObject slotObj = Instantiate(slotPrefab, this.transform);
                //アイテム生成
                Slot slot = slotObj.GetComponent<Slot>();
                slot.SetItem(null);
            }
        }
        
    }

}
