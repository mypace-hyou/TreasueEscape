using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float te;
    public bool boxNo_1;
    public bool boxNo_2;
    public bool boxNo_3;
    public bool boxNo_4;
    public bool boxNo_5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
