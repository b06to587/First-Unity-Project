using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainMenuHolder;               //메인메뉴를 가지고있는 오브젝트
    public GameObject optionsMenuHolder;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void GameStart()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
    }

    public void OptionsMenu(){              //옵션메뉴를 눌렀을때
        mainMenuHolder.SetActive(false);       //기본메뉴는 inactive
        optionsMenuHolder.SetActive(true);      // 옵션메뉴 activeㅉ
    }

}
