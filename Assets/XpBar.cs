using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XpBar : MonoBehaviour
{
    GameManager gameManager => GameManager.instance;
    Slider slider => GetComponent<Slider>();
    [SerializeField] Text text;

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = gameManager.xpLimit;
        slider.value = gameManager.xpAmount;
        if (gameManager.level == 9)
        {
            text.text = "Lvl: MAX";
        }
        else
        {
            text.text = "Lvl: " + gameManager.level;
        }
        
    }
}
