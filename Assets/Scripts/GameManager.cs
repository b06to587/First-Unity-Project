using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private Spawner spawner;
    public GameObject PauseMenu;
    public GameObject GameOverMenu;
    public Wall Wall;
    public Collider Player;
    public Text UIScore;
   
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            GamePause();
        }

        if(Ending.gameOver == true)
        {
            GameOver();
            Ending.gameOver = false;
        }
        UIScore.text="Score :" +Wall.GameScore;
    }
    
    public void GameStart()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
    }

    public void GamePause()
    {
        PauseMenu.SetActive(true);    
        Time.timeScale = 0;
    }

    public void GameContinue()
    {
        PauseMenu.SetActive(false);    
        Time.timeScale = 1;
    }

    public void GameEnd()
    {
        SceneManager.LoadScene("Start");
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverMenu.SetActive(true);
    }

    
    

}