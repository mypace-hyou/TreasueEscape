using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Items/key")]
public class key : Item
{
    private int keyObj;

    public int Key { get => keyObj;}
}