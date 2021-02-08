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
    // Start is called before the first frame update
    void Start()
    {
        PU = playerItem.GetComponent<playerUI>();
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
    //public void Event()
    //{
    //    Debug.Log("アイテムゲット");
    //}
}
