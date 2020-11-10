using UnityEngine;
using UnityEngine.UI;

public class playerUI : MonoBehaviour
{
    [SerializeField] GameObject Player_mov;
    [SerializeField] int hit;
    [SerializeField] private bool doorUI;
    [SerializeField] private bool boxUI, boxOC;
    public GameObject TextUI;
    void Start()
    {
        boxUI = false;
        boxOC = false;
        hit = 0;
        Player_mov = GameObject.Find("Player");
    }
    void Update()
    {
        UI();
    }
    public void UI()
    {
        PlayerMov pm = GetComponent<PlayerMov>();
        if (boxUI && hit == 1 || doorUI && hit == 2)
        {
            TextUI.gameObject.SetActive(true);
        }
        else if (!boxUI && hit == 0 || !doorUI && hit == 0)
        {
            TextUI.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown("space") && !boxOC && hit == 1)
        {
            boxOC = true;
        }
        else if (Input.GetKeyDown("space") && boxOC && hit == 1)
        {
            boxOC = false;
        }
        if (boxOC)
        {
            pm.speed = 0;
        }
        else if (!boxOC)
        {
            pm.speed = 6;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Box")
        {
            boxUI = true;
            hit = 1;
        }
        if (other.gameObject.tag == "Door")
        {
            doorUI = true;
            hit = 2;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Box")
        {
            boxUI = false;
            hit = 0;
        }
        if (col.gameObject.tag == "Door")
        {
            doorUI = true;
            hit = 0;
        }
    }
}