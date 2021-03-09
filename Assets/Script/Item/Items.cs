using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Items : MonoBehaviour
{
    public int myItemNumber;
    [Header("アイテムの画像を入れる")]
    public Sprite[] sprites;
    [SerializeField] private GameObject imageImage;
    bool ch;
    private Image image;
    [SerializeField] private GameObject itemObj;
    [SerializeField] private GameObject bag;
    MyItem mi;
    bool get;
    // Start is called before the first frame update
    void Start()
    {
        mi = bag.GetComponent<MyItem>();
        image = GetComponent<Image>();
        ch = false;
    }

    // Update is called once per frame
    void Update()
    {
        data();
        ItemGeneration();
    }
    void ItemGeneration()
    {
        switch (myItemNumber)
        {
            case 0:
                itemObj.tag = "obj";
                break;
            case 1:
                itemObj.tag = "obj";
                break;
            case 2:
                itemObj.tag = "obj";
                break;
            case 3:
                itemObj.tag = "obj";
                break;
            case 4:
                itemObj.tag = "obj";
                break;
            case 5:
                itemObj.tag = "obj";
                break;
            case 6:
                itemObj.tag = "obj";
                break;
            case 7:
                itemObj.tag = "obj";
                break;
            case 8:
                itemObj.tag = "obj";
                break;
            case 9:
                itemObj.tag = "obj";
                break;
            case 10:
                itemObj.tag = "key";
                break;
            case -1:
                break;
            default:
                break;
        }
    }
    public void pointerDown()
    {

    }
    public void drogUI()
    {
        transform.position = Input.mousePosition;
    }
    void data()
    {
        image.sprite = sprites[myItemNumber];
        ch = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bag" && myItemNumber == 10)
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "bag" && myItemNumber != 10)
        {
            get = true;
        }
        if (collision.gameObject.tag == "BoxBg" && get == true)
        {
            get = false;
            mi.getItemNum -= 1;
        }
    }
}
