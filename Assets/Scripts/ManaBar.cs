using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    [SerializeField] PlayerMana playerMana;
    Slider slider => GetComponent<Slider>();

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = playerMana.manaAmoutLimit;
        slider.value = playerMana.manaAmount;
    }
}
