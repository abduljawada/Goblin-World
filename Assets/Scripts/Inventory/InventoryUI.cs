using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public InventoryManager inventoryManager => InventoryManager.instance;
    
    void Start()
    {
        inventoryManager.onItemCangedCallback += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {
        Debug.Log("Update UI");
    }
}
