﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject Target;
    public Vector3 Offset = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Target == null) return;
        transform.position = Target.transform.position + Offset;
        transform.rotation = Target.transform.rotation;
    }
}
