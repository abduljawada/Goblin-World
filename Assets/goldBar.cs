using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldBar : MonoBehaviour
{
    InventoryManager inventoryManager => InventoryManager.instance;

    // Update is called once per frame
    void Update()
    {

         GetComponent<Text>().text = "Gold: " + inventoryManager.gold;
    }
}
