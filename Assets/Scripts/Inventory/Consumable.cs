using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : ItemProperties
{
    public int healthRestored;
    private void Awake()
    {
        type = ItemType.Consumable;
    }
}
