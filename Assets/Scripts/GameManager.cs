using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private Spawner spawner;
    public GameObject PauseMenu;
    public GameObject GameOverMenu;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            GamePause();
        }

        if(Menu.gameOver == true)
        {
            GameOver();
            Menu.gameOver = false;
        }
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