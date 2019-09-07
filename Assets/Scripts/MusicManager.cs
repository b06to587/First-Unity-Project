using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
//음악을 설정하는 스크립트
public class MusicManager : MonoBehaviour
{
    public AudioClip mainTheme;         // 메인음악클립을 담아두는 스크립트
    string sceneName;                   //현제 Scnen 이름

    void Start(){
      OnStartLoaded(0);                 //시작하자마자 음악을 실행
    }

    void OnStartLoaded(int sceneIndex){         
        string newSceneName = SceneManager.GetActiveScene().name;
        if(newSceneName != sceneName){
            sceneName = newSceneName;
            Invoke("PlayMusic",.2f);
        }
    }
    void PlayMusic(){
        AudioClip clipToPlay = null;
        if(sceneName =="main"){
            clipToPlay = mainTheme;
        }
    
        if(clipToPlay != null){
            AudioManager.instance.PlayMusic(clipToPlay,2);
            Invoke("PlayMusic", clipToPlay.length);
        }
    }

}