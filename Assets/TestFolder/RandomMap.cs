using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMap : MonoBehaviour
{
    //マップの最大値
    [Header("マップの最大値")]
    [SerializeField] [Range (10 , 100)]public int Max_X;
    [SerializeField] [Range(10, 100)] public int Max_Z;

    int Marking_X;
    int Marking_Z;
    // Start is called before the first frame update
    void Start()
    {
        Marking_X = Max_X;
        Marking_Z = Max_Z;
        int pos_Z = 0;

        for (; pos_Z < Max_Z; pos_Z++)
        {
            int pos_X = 0;
            for (; pos_X < Max_X; pos_X++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(pos_X, 0, pos_Z);
                if (pos_X == 0 || pos_Z == 0)
                {
                    cube.GetComponent<Renderer>().material.color = Color.red;
                }
                if (pos_X == Marking_X - 1 || pos_Z == Marking_Z - 1)
                {
                    cube.GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
        //int zPos = 0;
        //int xPos = 0;
        //// Z位置を+1しながらマップを生成していく
        //for (; zPos < 10; zPos++)
        //{
        //    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //    cube.transform.position = new Vector3(0, 0, zPos);
        //}
        //for (; xPos < 10; xPos++)
        //{
        //    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //    cube.transform.position = new Vector3(xPos, 0, 0);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
