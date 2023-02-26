using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapFunc : MonoBehaviour
{
   
    public Transform targetTransform;

    public RectTransform rectTransform;
    public Image image;

    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }

    public void Update()
    {
        var screenPoint = Camera.main.WorldToScreenPoint(targetTransform.position);
        rectTransform.position = screenPoint;
        
        var viewportPoint = Camera.main.WorldToViewportPoint(targetTransform.position);
        var distanceFromCenter = Vector2.Distance(viewportPoint, Vector2.one * 0.5f);

        var show = distanceFromCenter < 0.3f;

        image.enabled = show;

        
    }
}
