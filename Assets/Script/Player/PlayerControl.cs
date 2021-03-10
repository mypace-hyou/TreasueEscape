using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour
{
    public int te;
    public bool boxNo_1;
    public bool boxNo_2;
    public bool boxNo_3;
    public bool boxNo_4;
    public bool boxNo_5;

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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Box_1")
        {
            te = 0;
        }
        if (other.gameObject.tag == "Box_2")
        {
            te = 1;
        }
        if (other.gameObject.tag == "Box_3")
        {
            te = 2;
        }
        if (other.gameObject.tag == "Box_4")
        {
            te = 3;
        }
        if (other.gameObject.tag == "Box_5")
        {
            te = 4;
        }
        if (other.gameObject.tag == "Box_6")
        {
            te = 5;
        }
        if (other.gameObject.tag == "Box_7")
        {
            te = 6;
        }
        if (other.gameObject.tag == "Box_8")
        {
            te = 7;
        }
        if (other.gameObject.tag == "Box_9")
        {
            te = 8;
        }
        if (other.gameObject.tag == "Box_10")
        {
            te = 9;
        }
        if (other.gameObject.tag == "Box_9")
        {
            te = 10;
        }
        if (other.gameObject.tag == "KeyBox")
        {
            te = 11;
        }
        if (other.gameObject.tag == "Box_fake")
        {
            te = 12;
        }
    }
}
