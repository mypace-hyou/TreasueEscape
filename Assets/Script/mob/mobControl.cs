using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobControl : MonoBehaviour
{
    public GameObject VisualAngle;
    public float movCheng;
    public float maxAngle;
    public float minAngle;
    // Start is called before the first frame update
    void Start()
    {
        movCheng = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var diff = VisualAngle.transform.position - transform.position;
        var axis = Vector3.Cross(transform.forward, diff);
        var angle = Vector3.Angle(transform.forward, diff) * (axis.y < 0 ? -1 : 1);
        if (angle <= maxAngle && angle >= minAngle)
        {
            RaycastHit hit;
            Vector3 temp = VisualAngle.transform.position - this.transform.position;
            Vector3 normal = temp.normalized;
            if (Physics.Raycast(this.transform.position,normal,out hit,10))
            {
                if (hit.transform.gameObject == VisualAngle)
                {
                    //視界に対象のオブジェクトが来たときの処理
                    movCheng = /*1*/3;
                }
                else
                {
                    //視界と対象のオブジェクトの間に障害物があるときの処理
                    movCheng = /*2*/3;
                }
            }
            else
            {
                //対象のオブジェクトが視界にいないときの処理
                movCheng = /*0*/3;
            }
        }
    }
}
