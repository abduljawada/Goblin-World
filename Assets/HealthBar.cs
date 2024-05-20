using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    [SerializeField] Health playerHealth;
    Slider slider => GetComponent<Slider>();

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = playerHealth.healthLimit;
        slider.value = playerHealth.healthAmount;
    }
}
