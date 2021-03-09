﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour, IPointerClickHandler
{
    public float te;
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

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("攻撃力は" + MyItem.MyItamName + "です");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Box_1")
        {
            te = 1;
        }
        if (other.gameObject.tag == "Box_2")
        {
            te = 2;
        }
        if (other.gameObject.tag == "Box_3")
        {
            te = 3;
        }
        if (other.gameObject.tag == "Box_4")
        {
            te = 4;
        }
        if (other.gameObject.tag == "Box_5")
        {
            te = 5;
        }
    }
}
