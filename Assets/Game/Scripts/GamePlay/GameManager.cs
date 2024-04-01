using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : Singleton< GameManager>
{

    [SerializeField] public Transform posStart;
    [SerializeField]public TextMeshProUGUI textScore;

    private int score;
   public bool game = false;
    void Start()
    {
        UIManager.Ins.Menugame();
    }

    // Update is called once per frame
   
     
  public  void Init()
    {
        score = 0;
        Ground.Instance.Init();
        LiveText();
        game = true;


    }

    public void UpScore()
    {
        score++;
        LiveText();
        if (score == 10)
        {
            Vistory();
        }
    }
    public void LiveText()
    {
        textScore.text = "Score : " + score.ToString();
    }
    private void Vistory()
    {
        UIManager.Ins.Victory();
        game = false;
        Ground.Instance.DestroySphere();

    }
    public void Dead()
    {
        UIManager.Ins.Fail();
        game = false;
        Ground.Instance.DestroySphere();
    }



}
