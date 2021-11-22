using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour
{
    gamemanager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<gamemanager>();
    }
    public void fedeOut()
    {
        gm.gameStartCh = true;
    }
}
