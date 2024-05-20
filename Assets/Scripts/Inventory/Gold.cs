using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Interactable
{
    InventoryManager inventoryManager => InventoryManager.instance;
    public int amount;
    public override void Interact()
    {

        //#Pick up
        inventoryManager.Add(amount);
        base.Interact();
        Destroy(this.gameObject);
    }
}
