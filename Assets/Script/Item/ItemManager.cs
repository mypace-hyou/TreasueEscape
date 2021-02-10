using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    List<string> PlayerItemList = new List<string>();
    int getItemNum = 10;
    int loseItemNum = 10;
    void Start()
    {

    }
    void Update()
    {
        
    }
    public void GetItemList()
    {
        switch (getItemNum)
        {
            case 0:
                PlayerItemList.Add("気まぐれの人");
                getItemNum = 10;
                break;
            case 1:
                PlayerItemList.Add("病んでる糸");
                getItemNum = 10;
                break;
            case 2:
                PlayerItemList.Add("かっこつけ");
                getItemNum = 10;
                break;
            case 3:
                PlayerItemList.Add("サメハダ大臣");
                getItemNum = 10;
                break;
            case 4:
                PlayerItemList.Add("ロジックストーン");
                getItemNum = 10;
                break;
            case 5:
                PlayerItemList.Add("大行進");
                getItemNum = 10;
                break;
            case 6:
                PlayerItemList.Add("先陣を切って潜るペンギン");
                getItemNum = 10;
                break;
            case 7:
                PlayerItemList.Add("水をあげる棒人間");
                getItemNum = 10;
                break;
            case 8:
                PlayerItemList.Add("忙人暇人生活図");
                getItemNum = 10;
                break;
            case 9:
                PlayerItemList.Add("珍獣を馬乗りのするやつ");
                getItemNum = 10;
                break;
            default:
                break;
        }
    }
    public void LoseItemList()
    {
        switch (loseItemNum)
        {
            case 0:
                PlayerItemList.Remove("気まぐれの人");
                loseItemNum = 10;
                break;
            case 1:
                PlayerItemList.Remove("病んでる糸");
                loseItemNum = 10;
                break;
            case 2:
                PlayerItemList.Remove("かっこつけ");
                loseItemNum = 10;
                break;
            case 3:
                PlayerItemList.Remove("サメハダ大臣");
                loseItemNum = 10;
                break;
            case 4:
                PlayerItemList.Remove("ロジックストーン");
                loseItemNum = 10;
                break;
            case 5:
                PlayerItemList.Remove("大行進");
                loseItemNum = 10;
                break;
            case 6:
                PlayerItemList.Remove("先陣を切って潜るペンギン");
                loseItemNum = 10;
                break;
            case 7:
                PlayerItemList.Remove("水をあげる棒人間");
                loseItemNum = 10;
                break;
            case 8:
                PlayerItemList.Remove("忙人暇人生活図");
                loseItemNum = 10;
                break;
            case 9:
                PlayerItemList.Remove("珍獣を馬乗りのするやつ");
                loseItemNum = 10;
                break;
            default:
                break;
        }
    }
}
