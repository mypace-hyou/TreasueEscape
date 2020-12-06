using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int zPos = 0;
    public GameObject cube;
    
    public 
    // Start is called before the first frame update
    void Start()
    {
        // Z位置を+1しながらマップを生成していく
        for (; zPos < 10; zPos++)
        {
            cube.transform.position = new Vector3(0, 0, zPos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
