using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGrit : MonoBehaviour
{
    public GameObject slotGrit;
    int resetnum = 0;
    [SerializeField]
    private GameObject slotPrefab;
    
    private int slotNumber = 28;//初期のボックス内に表示するスロットの数
    public List<int> itemHaveList = new List<int>();

    [SerializeField]
    private Item[] allItems;
    private int ItemImageNum = 0;
    [SerializeField] GameObject slotObj;
    [SerializeField] Slot slot;

    public List<int> BoxNumberList = new List<int>();
    [SerializeField] GameObject player;
    PlayerControl pc;
    public bool HitBox = false;

    private int whatNumber;
    bool test = false;
    void Start()
    {
        pc = player.GetComponent<PlayerControl>();
        for (int i = 0; i < 11;)//ボックス事に表示する場所を決める
        {
            int ran = Random.Range(1, 29);
            bool ch = BoxNumberList.Contains(ran);
            if (!ch)
            {
                BoxNumberList.Add(ran);
                i++;
            }
        }
        for (int i = 0; i < 11;)//どこに生成させる場所を決める
        {
            int ran = Random.Range(0, 29);
            bool ch = itemHaveList.Contains(ran);
            if (!ch)
            {
                itemHaveList.Add(ran);
                i++;
            }
        }
        for (int i = 0; i < slotNumber; i++)
        {
            //スロット生成
            slotObj = Instantiate(slotPrefab, this.transform);
            Debug.Log("スロット作成");
            //アイテム生成
            slot = slotObj.GetComponent<Slot>();

            bool jg = itemHaveList.Contains(i);
            if (jg)
            {
                int num = itemHaveList.IndexOf(i);
                ItemImageNum = num;

                if (whatNumber < allItems.Length)
                {
                    Debug.Log("アイテムセット");
                    //アイテムセット
                    slot.SetItem(allItems[ItemImageNum]);
                    whatNumber++;
                }
                else
                {
                    slot.SetItem(null);
                }
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            test = true;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            test = false;
        }
        if (test)
        {
            testChildren();
        }
    }
    [SerializeField] private GameObject parentObject;

    // Use this for initialization
    void testChildren()
    {
        switch (resetnum)
        {
            case 0://子オブジェクトを消す
                foreach (Transform childTransform in parentObject.transform)
                {
                    Destroy(childTransform.gameObject);
                }
                whatNumber = 0;
                Debug.Log(resetnum);
                resetnum = 1;
                break;
            case 1://子オブジェクト再生成
                for (int i = 0; i < slotNumber; i++)
                {
                    Debug.Log(resetnum);
                    //スロット生成
                    slotObj = Instantiate(slotPrefab, this.transform);
                    //アイテム生成
                    slot = slotObj.GetComponent<Slot>();

                    bool jg = itemHaveList.Contains(i);
                    if (jg)
                    {
                        int num = itemHaveList.IndexOf(i);
                        ItemImageNum = num;

                        if (whatNumber < allItems.Length)
                        {
                            //アイテムセット
                            slot.SetItem(allItems[ItemImageNum]);
                            whatNumber++;
                        }
                        else
                        {
                            slot.SetItem(null);
                        }
                    }
                    if (i < slotNumber && whatNumber < allItems.Length)
                    {
                        resetnum = 2;
                    }
                }
                break;
            case 2://待機
                Debug.Log(resetnum);
                break;
            default:
                break;
        }
    }
}
