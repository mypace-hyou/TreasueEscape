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
    void Start()
    {
        for (int i = 0; i < slotNumber; i++)
        {
            //スロット生成
            GameObject slotObj = Instantiate(slotPrefab, this.transform);
            //アイテム生成
            Slot slot = slotObj.GetComponent<Slot>();
            for (int j = 0; j < 11;)
            {
                int ran = Random.Range(0, 28);
                bool ch = itemHaveLiet.Contains(ran);
                if (!ch)
                {
                    itemHaveLiet.Add(ran);
                    j++;
                }
            }
            bool jg = itemHaveLiet.Contains(i);
            if (jg)
            {
                //アイテムセット
                if (i < allItems.Length)
                {
                    slot.SetItem(allItems[i]);
                }
                else
                {
                    slot.SetItem(null);
                }
            }
        }
        //ボックス内の中身をランダムの位置に表示
        //ボックスごとに表示が違う
    }
}
