using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMov : MonoBehaviour
{
    /// <summary>FPS のカメラ</summary>
    [SerializeField] Camera m_mainCamera;
    /// <summary>照準となる UI オブジェクト</summary>
    [SerializeField] Image m_crosshair;
    /// <summary>照準に敵を捕らえていない時の色</summary>    
    [SerializeField] Color m_noTarget;
    /// <summary>照準に敵を捕らえている時の色</summary>
    [SerializeField] Color m_onTarget;
    /// <summary>射撃可能距離</summary>
    [SerializeField, Range(10, 200)] float m_shootRange = 100f;
    /// <summary>照準の Ray が当たる Layer</summary>
    [SerializeField] LayerMask m_shootingLayer;


    private CharacterController m_control;

    private Vector3 m_moveDirection;
    private Vector3 m_camRotation;

    public float speed = 6;
    public float jumpSpeed = 1.5f;
    public float gravity = 0.5f;

    /// <summary>下に向くことのできる最小角度</summary>
    [Range(-45, -15)]
    public int minAngle = -30;
    /// <summary>上に向くことのできる最大角度</summary>
    [Range(30, 80)]
    public int maxAngle = 45;
    /// <summary>マウスの感度</summary>
    [Range(50, 500)]
    public int sensitivity = 200;
    playerUI player_Ui;
    void Start()
    {
        mouse_C();
        player_Ui = GetComponent<playerUI>();
    }
    void Update()
    {
        if (player_Ui.boxOC == false)
        {
            Rotate();
        }
        Move();
    }
    public void mouse_O()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void mouse_C()
    {
        m_control = GetComponent<CharacterController>();
        // マウスカーソルを消す（実行中は ESC キーを押すとマウスカーソルが表示される）
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Rotate()
    {
        transform.Rotate(Vector3.up * sensitivity * Time.deltaTime * Input.GetAxis("Mouse X"));

        m_camRotation.x -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        m_camRotation.x = Mathf.Clamp(m_camRotation.x, minAngle, maxAngle);
    }
    private void Move()
    {
        if (m_control.isGrounded)
        {
            m_moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            m_moveDirection = transform.TransformDirection(m_moveDirection);
        }

        m_moveDirection.y -= gravity * Time.deltaTime;
        m_control.Move(m_moveDirection * speed * Time.deltaTime);
    }
}
