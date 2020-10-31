using UnityEngine;
using UnityEngine.UI;

public class playerUI : PlayerMov
{
    [SerializeField] private bool boxUI;
    public GameObject TextUI;
    void Start()
    {
        boxUI = false;
    }
    void Update()
    {
        if (boxUI)
        {
            TextUI.gameObject.SetActive(true);
        }
        else if (!boxUI)
        {
            TextUI.gameObject.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Box")
        {
            boxUI = true;
        }
    }
}