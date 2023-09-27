using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject deadText;
    public GameObject RestartBtn;
    public GameObject ExitBtn;
    public TextMeshProUGUI scoreText;
    int score = 0;
    public int winScore = 50;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUp()
    {
        if(winText.activeSelf||deadText.activeSelf){

        }
        else{
          score++;
          scoreText.text = "Score: "+score.ToString();
        }
        if(score >= winScore)
        {
          if(deadText.activeSelf){

          }else{
            Win();
          }
        }
    }

    void Win()
    {
      winText.SetActive(true);
      RestartBtn.SetActive(true);
      ExitBtn.SetActive(true);
    }
    public void Dead()
    {
      if(winText.activeSelf){

      }
      else{
        deadText.SetActive(true);
        RestartBtn.SetActive(true);
        ExitBtn.SetActive(true);
      }
    }

    public void Restart()
    {
      SceneManager.LoadScene("game");
    }

    public void Exit()
    {
      Application.Quit();
    }
}
