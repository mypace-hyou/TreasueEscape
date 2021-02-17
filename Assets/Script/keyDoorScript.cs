using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyDoorScript : MonoBehaviour
{
    [SerializeField]private GameObject player;
    playerUI pu;
    //　ドアエリアに入っているかどうか
    [SerializeField] private bool isNear;
    //　ドアのアニメーター
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isNear = false;
        pu = player.GetComponent<playerUI>();

        //animator = transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isNear)
        {
            animator.SetBool("Open", !animator.GetBool("Open"));
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && pu.Havekey == true)
        {
            isNear = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            isNear = false;
        }
    }
}
