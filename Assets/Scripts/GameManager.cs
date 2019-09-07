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
    public Text UIhightScore;
    public Text FinalScore;
    public static int hightScore;
   
    void Start()
    {
        UIScore.text ="0";
        UIhightScore.text ="BEST :"+ hightScore;
    }

    void Update()
    {   
        if(hightScore<=Wall.GameScore){
            hightScore =Wall.GameScore;
            UIhightScore.text="BEST :" +Wall.GameScore;
        }


        if(Input.GetKeyDown(KeyCode.Escape)){
            GamePause();
        }

        if(Ending.gameOver == true)
        {
            GameOver();
            Ending.gameOver = false;
        }
        UIScore.text="Score :" +Wall.GameScore;
        FinalScore.text = "Score :" +Wall.GameScore;
    }
    
    public void GameStart()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
        
        if(hightScore<=Wall.GameScore){
            hightScore =Wall.GameScore;
        }
        Wall.GameScore =0;
        
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