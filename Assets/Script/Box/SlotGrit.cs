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
    void Start()
    {
        for (int j = 0; j < 11;)//どこに生成させる場所を決める
        {
            int ran = Random.Range(0, 28);
            bool ch = itemHaveLiet.Contains(ran);
            if (!ch)
            {
                itemHaveLiet.Add(ran);
                j++;
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
                ItemImageNum++;
            }
            else
            {
                slot.SetItem(null);
            }
        }
        //ボックスごとに表示が違う
    }
}
