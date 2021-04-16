using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    //　ドアエリアに入っているかどうか
    private bool isNear;
    //　ドアのアニメーター
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isNear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isNear)
        {
            animator.SetBool("OpenBox", !animator.GetBool("OpenBox"));
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
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
