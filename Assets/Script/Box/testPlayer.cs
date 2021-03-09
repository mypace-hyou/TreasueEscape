using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class testPlayer : MonoBehaviour,IPointerClickHandler
{
    private Item item;
    public Item MyItem { get => item; private set => item = value; }
    [SerializeField]
    private int atk;

    public int MyAtk
    {
        get
        {
            int itemAtk = 0;
            //if (MyItem != null) itemAtk = MyItem.MyAtk;
            return atk + itemAtk;
        }
    }

    public void SetItem(Item item)
    {
        MyItem = item;
        //Debug.Log("所持アイテムは" + MyItem.MyItamName+"です");
        //Debug.Log("レア度は" + MyItem.RarityNumber + "です");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("攻撃力は" + MyItem.MyItamName + "です");
    }
}
