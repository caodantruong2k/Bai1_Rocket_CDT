using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;

public class CanvansVictory : MonoBehaviour
{
    [SerializeField] Button menuGame;
    [SerializeField] Button next;
    void Start()
    {
        menuGame.onClick.AddListener(() => UIManager.Ins.OnMenu());
        next.onClick.AddListener(() =>Next());

    }
    private void Next()
    {
        UIManager.Ins.PlayeGame();

        GameManager.Ins.Init();

    }

   
}
