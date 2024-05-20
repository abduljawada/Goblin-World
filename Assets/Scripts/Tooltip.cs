using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    [SerializeField] Text tooltipText;
    [SerializeField] RectTransform backgroundRectTransform;
    [HideInInspector] public static Tooltip instance;

    void Awake()
    {
        instance = this;
        HideTooltip();
    }

    public void ShowTooltip(string tooltipString, Vector3 objectPosition, Color tooltipColour)
    {
        gameObject.SetActive(true);

        tooltipText.text = tooltipString;

        float textPaddingSize = 4f;
        backgroundRectTransform.sizeDelta = new Vector2(tooltipText.preferredWidth + textPaddingSize * 2f, tooltipText.preferredHeight + textPaddingSize * 2f);

        Vector2 viewportPoint = Camera.main.WorldToViewportPoint(objectPosition);

        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();

        rectTransform.anchorMin = viewportPoint;
        rectTransform.anchorMax = viewportPoint;

        tooltipText.color = tooltipColour;
    }

    public void HideTooltip()
    {
        gameObject.SetActive(false);
    }
}
