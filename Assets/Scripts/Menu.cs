using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject BG;

    public GameObject MainMenu;
    public GameObject Button_Start;
    public GameObject Button_Option;

    public GameObject PauseMenu;
    public GameObject Button_Resume;
    public GameObject Button_End;


    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GamePause();
        }
    }

    public void GamePause()
    {
        BG.SetActive(true);
        PauseMenu.SetActive(true);
        
        Time.timeScale = 0;
    }
    public void GameStart()
    {
        Time.timeScale = 1;
    }
    public void GameEnd()
    {
        
    }

    
}
