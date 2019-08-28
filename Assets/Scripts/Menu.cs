using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject BG;
    public GameObject MainMenu;
    public GameObject Button_Start;
    public GameObject Button_Option;


    public void GameStart(int num)
    {
       SceneManager.LoadScene(num);
    }



    
}
