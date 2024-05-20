using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public int gold;
    [SerializeField] int itemLimit = 7;
    [SerializeField] int weaponLimit = 3;
    [SerializeField] int itemCount = 0;
    [SerializeField] int weaponCount = 0;

    [HideInInspector] public static InventoryManager instance;

    public delegate void OnItemCanged();
    public OnItemCanged onItemCangedCallback;

    private void Awake()
    {
        instance = this;
    }
    public void Add(int amount)
    {
        gold += amount;
    }

    public void Remove(int amount)
    {
        gold -= amount;
    }
}
