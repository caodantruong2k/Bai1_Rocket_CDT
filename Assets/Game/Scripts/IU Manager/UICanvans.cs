using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class UICanvans : MonoBehaviour
{
    [SerializeField] bool isDestroyOnClose = false;

    private void Awake()
    {
        RectTransform rect = GetComponent<RectTransform>();
        float ratio = (float)Screen.width  / (float)Screen.height;
        if(ratio > 2.1f)
        {
            Vector2 leftBottom = rect.offsetMin;
            Vector2 rightBottom = rect.offsetMax;

            leftBottom.y = 0f;
            rightBottom.y = 100f;

            rect.offsetMin = leftBottom;
            rect.offsetMax = rightBottom;
        }
    }
    public virtual void Setup()
    {

    }

    public virtual void Open()
    {
       gameObject.SetActive(true);
    }
    public virtual void Close(float time)
    {
        Invoke (nameof(CloseDirectly), time);
    }
    public virtual void CloseDirectly()
    {
        if (isDestroyOnClose)
        {
            Destroy(gameObject);
        }
        else
        {
            gameObject.SetActive (false);
        }
    }
}
