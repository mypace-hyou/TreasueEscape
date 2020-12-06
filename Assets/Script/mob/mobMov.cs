using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobMov : MonoBehaviour
{
    public float speed;
    public bool ch;
    public float m_ch;
    public Vector3 ro;

    public Transform target;//追いかける対象をインスペクタから登録できる
    private Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        ch = false;
    }

    // Update is called once per frame
    void Update()
    {
        mobControl mc = GetComponent<mobControl>();
        m_ch = mc.movCheng;
        switch (m_ch)
        {
            case 0://徘徊モード
                if (ch == true)
                {
                    transform.position += transform.forward * speed * Time.deltaTime;
                }
                if (ch == false)
                {
                    transform.Rotate(ro);
                }
                break;
            case 1://追跡モード
                //ターゲットの方向に向きが変わる
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);
                //ターゲットのとこに向かって進む
                transform.position += transform.forward * speed;
                break;
            case 2://警戒モード
                break;
            case 3:
                Debug.Log("hit");
                break;
            default:
                break;
        }
    }
}
