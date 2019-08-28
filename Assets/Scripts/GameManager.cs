using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static bool gameOver = false;
    private Spawner spawner;
    public GameObject PauseMenu;
    public GameObject Button_Resume;
    public GameObject Button_End;
    //public Player player;
    // Start is called before the first frame update


    void Start()
    {
        //Time.timeScale = 0
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            GamePause();
        }
    }
    private void GamePause()
    {
        PauseMenu.SetActive(true);    
        Time.timeScale = 0;
    }
    public void GameResume(){
        PauseMenu.SetActive(false);    
        Time.timeScale = 1;
    }
    public void GameEnd()
    {
        SceneManager.LoadScene("Start");
    }

}