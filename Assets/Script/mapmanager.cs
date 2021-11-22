using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapmanager : MonoBehaviour
{
    [Header("プレイヤーのスポンポイント")]
    /// <summary>スポンポイントを入れる</summary>
    public GameObject PlayerSponPoint;
    /// <summary>スポンポイントのポジション保持</summary>
    public Vector3 psp;

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        psp = PlayerSponPoint.transform.position;
        Player.transform.position = psp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
