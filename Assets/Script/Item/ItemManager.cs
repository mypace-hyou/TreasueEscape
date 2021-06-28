using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager instance { get; private set; }
    [SerializeField] GameObject box_1;
    [SerializeField] int box_1num = -1;
    [SerializeField] GameObject box_2;
    [SerializeField] int box_2num = -1;
    [SerializeField] GameObject box_3;
    [SerializeField] int box_3num = -1;
    [SerializeField] GameObject box_4;
    [SerializeField] int box_4num = -1;
    [SerializeField] GameObject box_5;
    [SerializeField] int box_5num = -1;
    [SerializeField] GameObject box_6;
    [SerializeField] int box_6num = -1;
    [SerializeField] GameObject box_7;
    [SerializeField] int box_7num = -1;
    [SerializeField] GameObject box_8;
    [SerializeField] int box_8num = -1;
    [SerializeField] GameObject box_9;
    [SerializeField] int box_9num = -1;
    [SerializeField] GameObject box_10;
    [SerializeField] int box_10num = -1;
    [SerializeField] GameObject box_11;
    [SerializeField] int box_11num = -1;
    [SerializeField] GameObject box_12;
    [SerializeField] int box_12num = -1;
    [SerializeField] GameObject box_13;
    [SerializeField] int box_13num = -1;
    [SerializeField] GameObject box_14;
    [SerializeField] int box_14num = -1;
    [SerializeField] GameObject box_15;
    [SerializeField] int box_15num = -1;
    [SerializeField] GameObject box_16;
    [SerializeField] int box_16num = -1;
    [SerializeField] GameObject box_17;
    [SerializeField] int box_17num = -1;
    [SerializeField] GameObject box_18;
    [SerializeField] int box_18num = -1;
    [SerializeField] GameObject box_19;
    [SerializeField] int box_19num = -1;
    [SerializeField] GameObject box_20;
    [SerializeField] int box_20num = -1;

    public int BoxNumber = 0;
    private int list = 11;
    int b;
    /// <summary>アイテムを表示させるボックスナンバーを入れるList</summary>
    public List<float> boxNumList = new List<float>();

    private void Awake()
    {
        instance = this;
        for (b = 0; b < list;)
        {
            BoxNumber = Random.Range(0, 20);
            bool ch = boxNumList.Contains(BoxNumber);
            if (!ch)
            {
                boxNumList.Add(BoxNumber);
                Bn();
                b++;
            }
        }
    }
    public void Bn()
    {
        switch (BoxNumber)
        {
            case 0:
                box_1num = b;
                if (box_1num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_1.tag = "Box_1";
                            break;
                        case 1:
                            box_1.tag = "Box_2";
                            break;
                        case 2:
                            box_1.tag = "Box_3";
                            break;
                        case 3:
                            box_1.tag = "Box_4";
                            break;
                        case 4:
                            box_1.tag = "Box_5";
                            break;
                        case 5:
                            box_1.tag = "Box_6";
                            break;
                        case 6:
                            box_1.tag = "Box_7";
                            break;
                        case 7:
                            box_1.tag = "Box_8";
                            break;
                        case 8:
                            box_1.tag = "Box_9";
                            break;
                        case 9:
                            box_1.tag = "Box_10";
                            break;
                        case 10:
                            box_1.tag = "KeyBox";
                            break;
                        case -1:
                            box_1.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 1:
                box_2num = b;
                if (box_2num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_2.tag = "Box_1";
                            break;
                        case 1:
                            box_2.tag = "Box_2";
                            break;
                        case 2:
                            box_2.tag = "Box_3";
                            break;
                        case 3:
                            box_2.tag = "Box_4";
                            break;
                        case 4:
                            box_2.tag = "Box_5";
                            break;
                        case 5:
                            box_2.tag = "Box_6";
                            break;
                        case 6:
                            box_2.tag = "Box_7";
                            break;
                        case 7:
                            box_2.tag = "Box_8";
                            break;
                        case 8:
                            box_2.tag = "Box_9";
                            break;
                        case 9:
                            box_2.tag = "Box_10";
                            break;
                        case 10:
                            box_2.tag = "KeyBox";
                            break;
                        case -1:
                            box_2.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 2:
                box_3num = b;
                if (box_3num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_3.tag = "Box_1";
                            break;
                        case 1:
                            box_3.tag = "Box_2";
                            break;
                        case 2:
                            box_3.tag = "Box_3";
                            break;
                        case 3:
                            box_3.tag = "Box_4";
                            break;
                        case 4:
                            box_3.tag = "Box_5";
                            break;
                        case 5:
                            box_3.tag = "Box_6";
                            break;
                        case 6:
                            box_3.tag = "Box_7";
                            break;
                        case 7:
                            box_3.tag = "Box_8";
                            break;
                        case 8:
                            box_3.tag = "Box_9";
                            break;
                        case 9:
                            box_3.tag = "Box_10";
                            break;
                        case 10:
                            box_3.tag = "KeyBox";
                            break;
                        case -1:
                            box_3.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 3:
                box_4num = b;
                if (box_4num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_4.tag = "Box_1";
                            break;
                        case 1:
                            box_4.tag = "Box_2";
                            break;
                        case 2:
                            box_4.tag = "Box_3";
                            break;
                        case 3:
                            box_4.tag = "Box_4";
                            break;
                        case 4:
                            box_4.tag = "Box_5";
                            break;
                        case 5:
                            box_4.tag = "Box_6";
                            break;
                        case 6:
                            box_4.tag = "Box_7";
                            break;
                        case 7:
                            box_4.tag = "Box_8";
                            break;
                        case 8:
                            box_4.tag = "Box_9";
                            break;
                        case 9:
                            box_4.tag = "Box_10";
                            break;
                        case 10:
                            box_4.tag = "KeyBox";
                            break;
                        case -1:
                            box_4.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 4:
                box_5num = b;
                if (box_5num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_5.tag = "Box_1";
                            break;
                        case 1:
                            box_5.tag = "Box_2";
                            break;
                        case 2:
                            box_5.tag = "Box_3";
                            break;
                        case 3:
                            box_5.tag = "Box_4";
                            break;
                        case 4:
                            box_5.tag = "Box_5";
                            break;
                        case 5:
                            box_5.tag = "Box_6";
                            break;
                        case 6:
                            box_5.tag = "Box_7";
                            break;
                        case 7:
                            box_5.tag = "Box_8";
                            break;
                        case 8:
                            box_5.tag = "Box_9";
                            break;
                        case 9:
                            box_5.tag = "Box_10";
                            break;
                        case 10:
                            box_5.tag = "KeyBox";
                            break;
                        case -1:
                            box_5.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 5:
                box_6num = b;
                if (box_6num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_6.tag = "Box_1";
                            break;
                        case 1:
                            box_6.tag = "Box_2";
                            break;
                        case 2:
                            box_6.tag = "Box_3";
                            break;
                        case 3:
                            box_6.tag = "Box_4";
                            break;
                        case 4:
                            box_6.tag = "Box_5";
                            break;
                        case 5:
                            box_6.tag = "Box_6";
                            break;
                        case 6:
                            box_6.tag = "Box_7";
                            break;
                        case 7:
                            box_6.tag = "Box_8";
                            break;
                        case 8:
                            box_6.tag = "Box_9";
                            break;
                        case 9:
                            box_6.tag = "Box_10";
                            break;
                        case 10:
                            box_6.tag = "KeyBox";
                            break;
                        case -1:
                            box_6.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 6:
                box_7num = b;
                if (box_7num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_7.tag = "Box_1";
                            break;
                        case 1:
                            box_7.tag = "Box_2";
                            break;
                        case 2:
                            box_7.tag = "Box_3";
                            break;
                        case 3:
                            box_7.tag = "Box_4";
                            break;
                        case 4:
                            box_7.tag = "Box_5";
                            break;
                        case 5:
                            box_7.tag = "Box_6";
                            break;
                        case 6:
                            box_7.tag = "Box_7";
                            break;
                        case 7:
                            box_7.tag = "Box_8";
                            break;
                        case 8:
                            box_7.tag = "Box_9";
                            break;
                        case 9:
                            box_7.tag = "Box_10";
                            break;
                        case 10:
                            box_7.tag = "KeyBox";
                            break;
                        case -1:
                            box_7.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 7:
                box_8num = b;
                if (box_8num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_8.tag = "Box_1";
                            break;
                        case 1:
                            box_8.tag = "Box_2";
                            break;
                        case 2:
                            box_8.tag = "Box_3";
                            break;
                        case 3:
                            box_8.tag = "Box_4";
                            break;
                        case 4:
                            box_8.tag = "Box_5";
                            break;
                        case 5:
                            box_8.tag = "Box_6";
                            break;
                        case 6:
                            box_8.tag = "Box_7";
                            break;
                        case 7:
                            box_8.tag = "Box_8";
                            break;
                        case 8:
                            box_8.tag = "Box_9";
                            break;
                        case 9:
                            box_8.tag = "Box_10";
                            break;
                        case 10:
                            box_8.tag = "KeyBox";
                            break;
                        case -1:
                            box_8.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 8:
                box_9num = b;
                if (box_9num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_9.tag = "Box_1";
                            break;
                        case 1:
                            box_9.tag = "Box_2";
                            break;
                        case 2:
                            box_9.tag = "Box_3";
                            break;
                        case 3:
                            box_9.tag = "Box_4";
                            break;
                        case 4:
                            box_9.tag = "Box_5";
                            break;
                        case 5:
                            box_9.tag = "Box_6";
                            break;
                        case 6:
                            box_9.tag = "Box_7";
                            break;
                        case 7:
                            box_9.tag = "Box_8";
                            break;
                        case 8:
                            box_9.tag = "Box_9";
                            break;
                        case 9:
                            box_9.tag = "Box_10";
                            break;
                        case 10:
                            box_9.tag = "KeyBox";
                            break;
                        case -1:
                            box_9.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 9:
                box_10num = b;
                if (box_10num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_10.tag = "Box_1";
                            break;
                        case 1:
                            box_10.tag = "Box_2";
                            break;
                        case 2:
                            box_10.tag = "Box_3";
                            break;
                        case 3:
                            box_10.tag = "Box_4";
                            break;
                        case 4:
                            box_10.tag = "Box_5";
                            break;
                        case 5:
                            box_10.tag = "Box_6";
                            break;
                        case 6:
                            box_10.tag = "Box_7";
                            break;
                        case 7:
                            box_10.tag = "Box_8";
                            break;
                        case 8:
                            box_10.tag = "Box_9";
                            break;
                        case 9:
                            box_10.tag = "Box_10";
                            break;
                        case 10:
                            box_10.tag = "KeyBox";
                            break;
                        case -1:
                            box_10.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 10:
                box_11num = b;
                if (box_11num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_11.tag = "Box_1";
                            break;
                        case 1:
                            box_11.tag = "Box_2";
                            break;
                        case 2:
                            box_11.tag = "Box_3";
                            break;
                        case 3:
                            box_11.tag = "Box_4";
                            break;
                        case 4:
                            box_11.tag = "Box_5";
                            break;
                        case 5:
                            box_11.tag = "Box_6";
                            break;
                        case 6:
                            box_11.tag = "Box_7";
                            break;
                        case 7:
                            box_11.tag = "Box_8";
                            break;
                        case 8:
                            box_11.tag = "Box_9";
                            break;
                        case 9:
                            box_11.tag = "Box_10";
                            break;
                        case 10:
                            box_11.tag = "KeyBox";
                            break;
                        case -1:
                            box_11.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 11:
                box_12num = b;
                if (box_12num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_12.tag = "Box_1";
                            break;
                        case 1:
                            box_12.tag = "Box_2";
                            break;
                        case 2:
                            box_12.tag = "Box_3";
                            break;
                        case 3:
                            box_12.tag = "Box_4";
                            break;
                        case 4:
                            box_12.tag = "Box_5";
                            break;
                        case 5:
                            box_12.tag = "Box_6";
                            break;
                        case 6:
                            box_12.tag = "Box_7";
                            break;
                        case 7:
                            box_12.tag = "Box_8";
                            break;
                        case 8:
                            box_12.tag = "Box_9";
                            break;
                        case 9:
                            box_12.tag = "Box_10";
                            break;
                        case 10:
                            box_12.tag = "KeyBox";
                            break;
                        case -1:
                            box_12.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 12:
                box_13num = b;
                if (box_13num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_13.tag = "Box_1";
                            break;
                        case 1:
                            box_13.tag = "Box_2";
                            break;
                        case 2:
                            box_13.tag = "Box_3";
                            break;
                        case 3:
                            box_13.tag = "Box_4";
                            break;
                        case 4:
                            box_13.tag = "Box_5";
                            break;
                        case 5:
                            box_13.tag = "Box_6";
                            break;
                        case 6:
                            box_13.tag = "Box_7";
                            break;
                        case 7:
                            box_13.tag = "Box_8";
                            break;
                        case 8:
                            box_13.tag = "Box_9";
                            break;
                        case 9:
                            box_13.tag = "Box_10";
                            break;
                        case 10:
                            box_13.tag = "KeyBox";
                            break;
                        case -1:
                            box_13.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 13:
                box_14num = b;
                if (box_14num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_14.tag = "Box_1";
                            break;
                        case 1:
                            box_14.tag = "Box_2";
                            break;
                        case 2:
                            box_14.tag = "Box_3";
                            break;
                        case 3:
                            box_14.tag = "Box_4";
                            break;
                        case 4:
                            box_14.tag = "Box_5";
                            break;
                        case 5:
                            box_14.tag = "Box_6";
                            break;
                        case 6:
                            box_14.tag = "Box_7";
                            break;
                        case 7:
                            box_14.tag = "Box_8";
                            break;
                        case 8:
                            box_14.tag = "Box_9";
                            break;
                        case 9:
                            box_14.tag = "Box_10";
                            break;
                        case 10:
                            box_14.tag = "KeyBox";
                            break;
                        case -1:
                            box_14.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 14:
                box_15num = b;
                if (box_15num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_15.tag = "Box_1";
                            break;
                        case 1:
                            box_15.tag = "Box_2";
                            break;
                        case 2:
                            box_15.tag = "Box_3";
                            break;
                        case 3:
                            box_15.tag = "Box_4";
                            break;
                        case 4:
                            box_15.tag = "Box_5";
                            break;
                        case 5:
                            box_15.tag = "Box_6";
                            break;
                        case 6:
                            box_15.tag = "Box_7";
                            break;
                        case 7:
                            box_15.tag = "Box_8";
                            break;
                        case 8:
                            box_15.tag = "Box_9";
                            break;
                        case 9:
                            box_15.tag = "Box_10";
                            break;
                        case 10:
                            box_15.tag = "KeyBox";
                            break;
                        case -1:
                            box_15.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 15:
                box_16num = b;
                if (box_16num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_16.tag = "Box_1";
                            break;
                        case 1:
                            box_16.tag = "Box_2";
                            break;
                        case 2:
                            box_16.tag = "Box_3";
                            break;
                        case 3:
                            box_16.tag = "Box_4";
                            break;
                        case 4:
                            box_16.tag = "Box_5";
                            break;
                        case 5:
                            box_16.tag = "Box_6";
                            break;
                        case 6:
                            box_16.tag = "Box_7";
                            break;
                        case 7:
                            box_16.tag = "Box_8";
                            break;
                        case 8:
                            box_16.tag = "Box_9";
                            break;
                        case 9:
                            box_16.tag = "Box_10";
                            break;
                        case 10:
                            box_16.tag = "KeyBox";
                            break;
                        case -1:
                            box_16.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 16:
                box_17num = b;
                if (box_17num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_17.tag = "Box_1";
                            break;
                        case 1:
                            box_17.tag = "Box_2";
                            break;
                        case 2:
                            box_17.tag = "Box_3";
                            break;
                        case 3:
                            box_17.tag = "Box_4";
                            break;
                        case 4:
                            box_17.tag = "Box_5";
                            break;
                        case 5:
                            box_17.tag = "Box_6";
                            break;
                        case 6:
                            box_17.tag = "Box_7";
                            break;
                        case 7:
                            box_17.tag = "Box_8";
                            break;
                        case 8:
                            box_17.tag = "Box_9";
                            break;
                        case 9:
                            box_17.tag = "Box_10";
                            break;
                        case 10:
                            box_17.tag = "KeyBox";
                            break;
                        case -1:
                            box_17.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 17:
                box_18num = b;
                if (box_18num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_18.tag = "Box_1";
                            break;
                        case 1:
                            box_18.tag = "Box_2";
                            break;
                        case 2:
                            box_18.tag = "Box_3";
                            break;
                        case 3:
                            box_18.tag = "Box_4";
                            break;
                        case 4:
                            box_18.tag = "Box_5";
                            break;
                        case 5:
                            box_18.tag = "Box_6";
                            break;
                        case 6:
                            box_18.tag = "Box_7";
                            break;
                        case 7:
                            box_18.tag = "Box_8";
                            break;
                        case 8:
                            box_18.tag = "Box_9";
                            break;
                        case 9:
                            box_18.tag = "Box_10";
                            break;
                        case 10:
                            box_18.tag = "KeyBox";
                            break;
                        case -1:
                            box_18.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 18:
                box_19num = b;
                if (box_19num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_19.tag = "Box_1";
                            break;
                        case 1:
                            box_19.tag = "Box_2";
                            break;
                        case 2:
                            box_19.tag = "Box_3";
                            break;
                        case 3:
                            box_19.tag = "Box_4";
                            break;
                        case 4:
                            box_19.tag = "Box_5";
                            break;
                        case 5:
                            box_19.tag = "Box_6";
                            break;
                        case 6:
                            box_19.tag = "Box_7";
                            break;
                        case 7:
                            box_19.tag = "Box_8";
                            break;
                        case 8:
                            box_19.tag = "Box_9";
                            break;
                        case 9:
                            box_19.tag = "Box_10";
                            break;
                        case 10:
                            box_19.tag = "KeyBox";
                            break;
                        case -1:
                            box_19.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            case 19:
                box_20num = b;
                if (box_20num == b)
                {
                    switch (b)
                    {
                        case 0:
                            box_20.tag = "Box_1";
                            break;
                        case 1:
                            box_20.tag = "Box_2";
                            break;
                        case 2:
                            box_20.tag = "Box_3";
                            break;
                        case 3:
                            box_20.tag = "Box_4";
                            break;
                        case 4:
                            box_20.tag = "Box_5";
                            break;
                        case 5:
                            box_20.tag = "Box_6";
                            break;
                        case 6:
                            box_20.tag = "Box_7";
                            break;
                        case 7:
                            box_20.tag = "Box_8";
                            break;
                        case 8:
                            box_20.tag = "Box_9";
                            break;
                        case 9:
                            box_20.tag = "Box_10";
                            break;
                        case 10:
                            box_20.tag = "KeyBox";
                            break;
                        case -1:
                            box_20.tag = "Box_fake";
                            break;
                        default:
                            break;
                    }
                }
                break;
            default:
                break;
        }
    }
}
