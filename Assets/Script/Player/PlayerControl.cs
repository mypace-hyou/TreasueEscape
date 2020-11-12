using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float boxRd;
    public bool boxNo_1;
    public bool boxNo_2;
    public bool boxNo_3;
    public bool boxNo_4;
    public bool boxNo_5;
    public playerUI box;
    public GameObject box_Item;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<playerUI>();
        box_Item = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        gamemanager GM = box_Item.GetComponent<gamemanager>();
        boxRd = GM.Ram_Treasure;
    }
    public void treasurePlacement()
    {
        switch (boxRd)
        {
            case 0:
                boxNo_1 = true;
                break;
            case 1:
                boxNo_2 = true;
                break;
            case 2:
                boxNo_3 = true;
                break;
            case 3:
                boxNo_4 = true;
                break;
            case 4:
                boxNo_5 = true;
                break;
            default:
                break;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Box_1")
        {
            
        }
        if (other.gameObject.tag == "Box_2")
        {

        }
        if (other.gameObject.tag == "Box_3")
        {
            
        }
        if (other.gameObject.tag == "Box_4")
        {
            
        }
        if (other.gameObject.tag == "Box_5")
        {
            
        }
    }
}
