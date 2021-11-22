using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Items",menuName ="Items/item")]
public class Item : ScriptableObject
{
    /// <summary>アイテムの名前</summary>
    [SerializeField]
    private string itamName;
    /// <summary>アイテムの画像</summary>
    [SerializeField]
    private Sprite itemImage;
    /// <summary>アイテムナンバー</summary>
    [SerializeField]
    private int itemNumber;
    int num;
    public string MyItamName { get => itamName;}
    public Sprite MyItemImage { get => itemImage; }
    public int RarityNumber { get => num;}
    public int haveListNumber { get => itemNumber; }
}
