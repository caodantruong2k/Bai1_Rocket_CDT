using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvansGame : MonoBehaviour
{
    [SerializeField] Button setting;

    private void Start()
    {
        setting.onClick.AddListener(() => UIManager.Ins.Setting());
    }
}
