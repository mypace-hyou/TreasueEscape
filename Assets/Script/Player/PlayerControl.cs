using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour
{
    public int te;

    private Item item;
    public Item MyItem { get => item; private set => item = value; }
    private key key;
    public key MyKey { get => key; private set => key = value; }
    [SerializeField]
    private int atk;
    public int keyNumber;
    public int ItemNumber;
    gamemanager gm;
    List<int> itemHaveNumberList = new List<int>();
    public int MyAtk
    {
        get
        {
            key key = MyKey as key;

            int itemAtk = 0;
            if (key != null) itemAtk = MyKey.Key;
            return atk + itemAtk;
        }
    }
    void Awake()
    {
        gm = FindObjectOfType<gamemanager>();
    }
    public void SetItem(Item item)
    {
        MyItem = item;
        bool have = itemHaveNumberList.Contains(MyItem.haveListNumber);
        if (!have && MyItem.RarityNumber == 0)
        {
            itemHaveNumberList.Add(MyItem.haveListNumber);
            gm.ItemCh++;
        }
        if ("key" == MyItem.MyItamName)
        {
            gm.keyHaveCH = true;
        }
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
        if (other.gameObject.tag == "KeyBox")
        {
            te = 10;
        }
        if (other.gameObject.tag == "Box_fake")
        {
            te = -1;
        }
    }
}
