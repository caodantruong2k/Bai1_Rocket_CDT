using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;

public class CanvansMainmenu : MonoBehaviour
{
    [SerializeField] Button gamePlay;
    [SerializeField] Button setting;
    void Start()
    {
        gamePlay.onClick.AddListener(() => Play());
     //   setting.onClick.AddListener(() => UIManager.Ins.Setting());
     

    }

   private void Play()
    {
        UIManager.Ins.PlayeGame();
        GameManager.Ins.Init();
    }
}
