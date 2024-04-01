using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvansFail : MonoBehaviour
{
    [SerializeField] Button menuGame;
    [SerializeField] Button retry;
    void Start()
    {
        menuGame.onClick.AddListener(() => UIManager.Ins.OnMenu());

        retry.onClick.AddListener(() =>Retry());


    }
  
    
    private void Retry()
    {
         UIManager.Ins.PlayeGame();

         GameManager.Ins.Init();
    }

}
