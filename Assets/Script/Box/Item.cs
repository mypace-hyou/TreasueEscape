using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Items",menuName ="Items/item")]
public class Item : ScriptableObject
{
    [SerializeField]
    private string itamName;
    [SerializeField]
    private Sprite itemImage;
    [SerializeField]
    private int Rarity;
    gamemanager gm;
    int num;

    private void Awake()
    {
        num = gm.ran;
    }


    //立ち絵の変更するときは戻す(set => itamName = value;　を付ける)
    public string MyItamName { get => itamName;}
    public Sprite MyItemImage { get => itemImage; }
    public int RarityNumber { get => num; set => num = value; }
}
