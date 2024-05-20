using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonConsumable : ItemProperties
{
    private void Awake()
    {
        type = ItemType.NonConsumable;
    }
}