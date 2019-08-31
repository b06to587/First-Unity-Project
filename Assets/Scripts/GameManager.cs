using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private Spawner spawner;
    public GameObject PauseMenu;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            GamePause();
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

    

}