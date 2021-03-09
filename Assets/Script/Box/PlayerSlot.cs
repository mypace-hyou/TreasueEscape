using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerSlot : Slot
{
    private PlayerControl player;
    public PlayerControl MyPlayer { get => player; private set => player = value; }
    protected override void Start()
    {
        base.Start();
        MyPlayer = FindObjectOfType<PlayerControl>();
    }
    public override void OnDrop(PointerEventData eventData)
    {
        base.OnDrop(eventData);
        player.SetItem(MyItem);
    }
}
