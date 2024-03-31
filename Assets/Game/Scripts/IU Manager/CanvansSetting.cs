using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvansSetting : MonoBehaviour
{
    [SerializeField] Button playerGame;
    [SerializeField] Button mainMenu;
    
    void Start()
    {
        playerGame.onClick.AddListener(() => UIManager.Ins.PlayeGame());
        mainMenu.onClick.AddListener(() => UIManager.Ins.OnMenu());
        
    }

 

    
}
