using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyItem : MonoBehaviour
{
    playerUI pu;
    public GameObject player;
    public int getItemNum;
    // Start is called before the first frame update
    void Start()
    {
        pu = player.GetComponent<playerUI>();
        getItemNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="key")
        {
            pu.Havekey = true;
        }
        if (collision.gameObject.tag == "obj")
        {
            getItemNum += 1;
            Debug.Log(getItemNum);
        }
    }
}
