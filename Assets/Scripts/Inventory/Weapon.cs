using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ItemProperties
{
    public int strBonus;
    public int dexBonus;
    private void Awake()
    {
        type = ItemType.Weapon;
    }
}