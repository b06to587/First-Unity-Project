using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject BG;
    public GameObject MainMenu;
    public GameObject PauseMenu;
    public GameObject GameOverMenu;

    public bool gameOver = false;

    void Start()
    {
        //Time.timeScale = 0;
    }

    void Update()
    {
        if(gameOver == true)
        {
            GameOver();
            gameOver = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")     
        {
            gameOver = true;
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverMenu.SetActive(true);
    }
    
}
