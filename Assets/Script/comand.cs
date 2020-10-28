using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class comand : MonoBehaviour
{
    public static comand instanc { get; private set; }
    public string com;
    public Text cod;

    public List<string> commandList;
    public int num;
    void Start()
    {
        instanc = this;
        commandList = new List<string>()
        {
            "sper",
            "nomal",
        };
    }
    void Update()
    {
        
    }
    public void CommandList()
    {
        if (commandList.Contains(InputManager.instanc.inputValue))
        {
            num = commandList.IndexOf(InputManager.instanc.inputValue) + 1;
            Debug.Log(InputManager.instanc.inputValue + "のコマンドあり");
            CommandListNomber();
        }
        else
        {
            Debug.Log(InputManager.instanc.inputValue + "のコマンドはない");
        }
    }
    public void CommandListNomber()
    {
        if (num == 1)
        {
            Debug.Log(num);
            cod.text = "aaa";
        }
        if (num == 2)
        {
            Debug.Log(num);
            cod.text = "bbb";
        }
        if (num == 3)
        {
            Debug.Log(num);
            cod.text = "ccc";
        }
    }
}
