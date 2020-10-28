using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public static InputManager instanc { get; private set; }
    InputField inputField;
    public string inputValue;
    // Start is called before the first frame update
    void Start()
    {
        instanc = this;
        inputField = GetComponent<InputField>();

        InitInputField();
    }



    /// <summary>
    /// Log出力用メソッド
    /// 入力値を取得してLogに出力し、初期化
    /// </summary>


    public void InputLogger()
    {

        inputValue = inputField.text;


        InitInputField();

        comand.instanc.CommandList();
    }



    /// <summary>
    /// InputFieldの初期化用メソッド
    /// 入力値をリセットして、フィールドにフォーカスする
    /// </summary>


    void InitInputField()
    {
        // 値をリセット
        inputField.text = "";

        // フォーカス
        inputField.ActivateInputField();
    }

}
