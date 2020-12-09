using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int zPos = 0;
    public int xPos = 0;
    public GameObject cube;
    
    void Start()
    {
        int zPos = 0;
        int xPos = 0;

        // Z位置を+1しながらマップを生成していく
        for (; zPos < 15; zPos++)
        {
            // Z位置が更新されたら、まず1つマップチップを置く
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(xPos, 0, zPos);

            // 現在のマップ生成のX位置から移動できるX方向の範囲を決定
            int randomAddTips_Min = -3 - xPos;
            int randomAddTips_Max = 3 - xPos;

            // 乱数を用意して、その値分X方向に移動する。0が出たら曲がらず直進する
            int randomAddTips = Random.Range(randomAddTips_Min, randomAddTips_Max + 1);
            // 乱数が0以上なら右に曲がり、乱数分進む
            if (randomAddTips > 0)
            {
                for (; randomAddTips > 0; randomAddTips--)
                {
                    xPos++;
                    cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(xPos, 0, zPos);
                }
            }
            // 乱数が0以下なら左に曲がり、乱数分進む
            if (randomAddTips < 0)
            {
                for (; randomAddTips < 0; randomAddTips++)
                {
                    xPos--;
                    cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(xPos, 0, zPos);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
