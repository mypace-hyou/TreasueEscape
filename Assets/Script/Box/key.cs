using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Items/key")]
public class key : Item
{
    [SerializeField]
    private int keyObj = 1;

    public int Key { get => keyObj; set => keyObj = value; }
}