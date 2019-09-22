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
    public WallSet WallSet;
    public Collider Player;
    public Text UIScore;
    public Text UIhightScore;
    public Text FinalScore;
    public static int hightScore;
   
    void Start()
    {
        UIScore.text ="0";
        hightScore=PlayerPrefs.GetInt("BestScore");
        UIhightScore.text ="BEST :"+ hightScore;
    }

    void Update()
    {   
        if(hightScore<=WallSet.gamseScore){
            hightScore =WallSet.gamseScore;
            UIhightScore.text="BEST :" +WallSet.gamseScore;
        }


        if(Input.GetKeyDown(KeyCode.Escape)){
            GamePause();
        }

        if(Ending.gameOver == true)
        {
            GameOver();
            Ending.gameOver = false;
        }
        UIScore.text="Score :" +WallSet.gamseScore;
        FinalScore.text = "Score :" +WallSet.gamseScore;
        PlayerPrefs.SetInt("BestScore",hightScore);
    }
    
    public void GameStart()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
        
        if(hightScore<=WallSet.gamseScore){
            hightScore =WallSet.gamseScore;
        }
        WallSet.gamseScore =0;
        
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
        WeaponChange.weaponEnchantTime = 6;
    }
}