using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instanc { get; private set; }
    public float Ram_Treasure;
    // Start is called before the first frame update
    void Start()
    {
        Ram_Treasure = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
