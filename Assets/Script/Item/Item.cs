using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Item : MonoBehaviour
{
    public int myItemNumber;
    [Header("アイテムの画像を入れる")]
    public Sprite[] sprites;
    [SerializeField] private GameObject imageImage;
    bool ch;
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        ch = false;
    }

    // Update is called once per frame
    void Update()
    {
        data();
    }
    void ItemGeneration()
    {

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
        
    }
}
