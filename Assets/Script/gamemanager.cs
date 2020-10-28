using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instanc { get; private set; }
    public GameObject comset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Slash))
        //{
        //    comset.gameObject.SetActive(true);
        //    //PlayerMov.instanc.charStop();
        //    PlayerMov.instanc.ch = false;
        //}
        //if (Input.GetKey(KeyCode.KeypadEnter))
        //{
        //    comset_f();
        //}
    }
    public void comset_f()
    {
        comset.gameObject.SetActive(false);
        //PlayerMov.instanc.charGo();
    }
}
