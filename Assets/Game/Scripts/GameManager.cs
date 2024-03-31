using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : Singleton< GameManager>
{

    
    [SerializeField]public TextMeshProUGUI textScore;

    private int score;
   public bool game = true;
    void Start()
    {
        UIManager.Ins.Menugame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
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


}
