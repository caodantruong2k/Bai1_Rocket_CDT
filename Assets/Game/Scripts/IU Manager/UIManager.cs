using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] GameObject gameFail;
    [SerializeField] GameObject gameVictory;
    [SerializeField] GameObject gameSetting;
    [SerializeField] GameObject gameCanvas;
    [SerializeField] GameObject gameMenu;


    public void PlayeGame()
    {
        gameFail.SetActive(false);
        gameVictory.SetActive(false);
        gameSetting.SetActive(false);
        gameCanvas.SetActive(true);
        gameMenu.SetActive(false);
    }
    public void Setting()
    {
        gameFail.SetActive(false);
        gameVictory.SetActive(false);
        gameSetting.SetActive(true);
        gameCanvas.SetActive(false);
        gameMenu.SetActive(false);
    }

    public void Victory()
    {
        gameFail.SetActive(false);
        gameVictory.SetActive(true);
        gameSetting.SetActive(false);
        gameCanvas.SetActive(false);
        gameMenu.SetActive(false);
    }
    public void Fail()
    {
        gameFail.SetActive(true);
        gameVictory.SetActive(false);
        gameSetting.SetActive(false);
        gameCanvas.SetActive(false);
        gameMenu.SetActive(false);
    }
    public void Menugame()
    {
        gameFail.SetActive(false);
        gameVictory.SetActive(false);
        gameSetting.SetActive(false);
        gameCanvas.SetActive(false);
        gameMenu.SetActive(true);
    }
    public void OnMenu()
    {
        Ground.Instance.DestroySphere();
        Menugame();
    }
    
  
}
