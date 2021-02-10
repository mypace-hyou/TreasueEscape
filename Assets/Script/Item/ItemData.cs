using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    public enum Rarity
    {
        ばらばらの,
        ぼろぼろの,
        きらきらの,
        ぴかぴかの
    }
    [Header("気まぐれの人")]//(自由の女神
    [SerializeField] GameObject kimagure;
    [SerializeField] int khn = -1;

    [Header("病んでる糸")]//考える人
    [SerializeField] GameObject yanderu;
    [SerializeField] int yin = -1;

    [Header("かっこつけ")]//円盤投げ
    [SerializeField] GameObject kakkotuke;
    [SerializeField] int ktn = -1;

    [Header("サメハダ大臣")]//(カメハメハ大王)
    [SerializeField] GameObject samehada;
    [SerializeField] int sdn = -1;

    [Header("ロジックストーン")]//(ロゼッタストーン)
    [SerializeField] GameObject logicStone;
    [SerializeField] int lsn = -1;

    [Header("大行進")]//ビートルズのジャケ
    [SerializeField] GameObject greatMarch;
    [SerializeField] int gmn = -1;

    [Header("先陣を切って潜るペンギン")]//民衆を導く自由の女神
    [SerializeField] GameObject Firstpengin;
    [SerializeField] int spn = -1;

    [Header("水をあげる棒人間")]//牛乳を注ぐ女
    [SerializeField] GameObject water;
    [SerializeField] int mwn = -1;

    [Header("忙人暇人生活図")]//風神雷神図屏風
    [SerializeField] GameObject LifeMap;
    [SerializeField] int lmn = -1;

    [Header("珍獣を馬乗りのするやつ")]//真珠の耳飾りの少女
    [SerializeField] GameObject Ride;
    [SerializeField] int rdn = -1;

    [SerializeField] private int ItemNumber = 0;
    private int list = 9;
    int i;
    List<float> listNum = new List<float>();
    Item Item_kimagure;
    Item Item_yanderu;
    Item Item_kakkotuke;
    Item Item_samehada;
    Item Item_logicStone;
    Item Item_greatMarch;
    Item Item_Firstpengin;
    Item Item_water;
    Item Item_lifeMap;
    Item Item_ride;
    void Start()
    {
        getcon();
        for (i = 0; i <= list;)
        {
            ItemNumber = Random.Range(0, 10);
            bool ch = listNum.Contains(ItemNumber);
            if (!ch)
            {
                listNum.Add(ItemNumber);
                Sorting();
                i++;
            }
        }
        numpos();
    }
    void getcon()
    {
        Item_kimagure = kimagure.GetComponent<Item>();
        Item_yanderu = yanderu.GetComponent<Item>();
        Item_kakkotuke = kakkotuke.GetComponent<Item>();
        Item_samehada = samehada.GetComponent<Item>();
        Item_logicStone = logicStone.GetComponent<Item>();
        Item_greatMarch = greatMarch.GetComponent<Item>();
        Item_Firstpengin = Firstpengin.GetComponent<Item>();
        Item_water = water.GetComponent<Item>();
        Item_lifeMap = LifeMap.GetComponent<Item>();
        Item_ride = Ride.GetComponent<Item>();
    }
    void numpos()
    {
        Item_kimagure.myItemNumber = khn;
        Item_yanderu.myItemNumber = yin;
        Item_kakkotuke.myItemNumber = ktn;
        Item_samehada.myItemNumber = sdn;
        Item_logicStone.myItemNumber = lsn;
        Item_greatMarch.myItemNumber = gmn;
        Item_Firstpengin.myItemNumber = spn;
        Item_water.myItemNumber = mwn;
        Item_lifeMap.myItemNumber = lmn;
        Item_ride.myItemNumber = rdn;
    }
    void Sorting()
    {
        switch (i)
        {
            case 0:
                khn = ItemNumber;
                break;
            case 1:
                yin = ItemNumber;
                break;
            case 2:
                ktn = ItemNumber;
                break;
            case 3:
                sdn = ItemNumber;
                break;
            case 4:
                lsn = ItemNumber;
                break;
            case 5:
                gmn = ItemNumber;
                break;
            case 6:
                spn = ItemNumber;
                break;
            case 7:
                mwn = ItemNumber;
                break;
            case 8:
                lmn = ItemNumber;
                break;
            case 9:
                rdn = ItemNumber;
                break;
            default:
                break;
        }
    }
}
