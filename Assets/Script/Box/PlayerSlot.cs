using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerSlot : Slot
{
    private PlayerControl player;
    SlotGrit slotGrit;
    public PlayerControl MyPlayer { get => player; private set => player = value; }
    public SlotGrit MyGrit { get => slotGrit; private set => slotGrit = value; }
    protected override void Start()
    {
        base.Start();
        MyPlayer = FindObjectOfType<PlayerControl>();
        slotGrit = FindObjectOfType<SlotGrit>();
    }
    public override void OnDrop(PointerEventData eventData)
    {
        base.OnDrop(eventData);
        player.SetItem(MyItem);
    }
}
