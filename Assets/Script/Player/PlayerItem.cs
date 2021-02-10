using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    public GameObject playerItem;
    playerUI PU;
    public GameObject Item_1;
    public GameObject Item_2;
    public GameObject Item_3;
    public GameObject Item_4;
    public GameObject Item_5;
    public GameObject Item_6;
    public GameObject Item_7;
    public GameObject Item_8;
    public GameObject Item_9;
    public GameObject Item_10;

    //public Vector3 ItemPos_1;
    //public Vector3 ItemPos_2;
    //public Vector3 ItemPos_3;
    //public Vector3 ItemPos_4;
    //public Vector3 ItemPos_5;
    //public Vector3 ItemPos_6;
    //public Vector3 ItemPos_7;
    //public Vector3 ItemPos_8;
    //public Vector3 ItemPos_9;
    //public Vector3 ItemPos_10;
    // Start is called before the first frame update
    void Start()
    {
        PU = playerItem.GetComponent<playerUI>();
        //TP();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && PU.boxOC==false)
        {
            ItemCH();
        }
    }
    public void ItemCH()
    {
        PU.Item();
    }
    //public void TP()
    //{
    //    ItemPos_1 = Item_1.transform.position;
    //    ItemPos_2 = Item_2.transform.position;
    //    ItemPos_3 = Item_3.transform.position;
    //    ItemPos_4 = Item_4.transform.position;
    //    ItemPos_5 = Item_5.transform.position;
    //    ItemPos_6 = Item_6.transform.position;
    //    ItemPos_7 = Item_7.transform.position;
    //    ItemPos_8 = Item_8.transform.position;
    //    ItemPos_9 = Item_9.transform.position;
    //    ItemPos_10 = Item_10.transform.position;
    //}
}
