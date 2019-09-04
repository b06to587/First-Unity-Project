    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//오디오를 컨트롤하는 스크립트
public class AudioManager : MonoBehaviour
{
   public enum AudioChannel {Master,Sfx,Music};  // 오디오를 오디오채널이라는 이름으로 열거
   public float masterVolumePercent {get;private set;} // get접근자는 public 으로 받을수있지만, set 접근자는 private으로 제한된 접근
   public float sfxVolumePercent {get;private set;}
   public float musicVolumePercent {get;private set;}

    AudioSource sfx2DSource;    //  오디오2d 사운드 이팩트 소스 

    public static AudioManager instance;    //오디오 매니저 static 인스턴스 선언 Singleton 게임상에서 audio 객체는 하나만 필요 

    AudioSource musicSources;     //오디오소스 배열
    int activeMusicSourceIndex;             //실행하고있는 음악 index

    SoundLibrary library;
    void Awake(){
        if(instance != null){           //인스턴스 초기화
            Destroy(gameObject);            // 없으면 삭제
        }
        else {
            instance = this;                 // 아니라면 instance = this;

            DontDestroyOnLoad(gameObject);               //로드시에도 사라지지 않음
            library = GetComponent<SoundLibrary>();      // 사운드 라이브러리 스크립트를 가져옴

            GameObject newMusicSource = new GameObject("Music source "); // 하나의 배경음악을 담음
            musicSources = newMusicSource.AddComponent<AudioSource>();
            newMusicSource.transform.parent = transform; 

            GameObject newSfx2DSource = new GameObject("2D sfx source ");   // 사운드 이팩트를 담음
            sfx2DSource = newSfx2DSource.AddComponent<AudioSource>();
            newSfx2DSource.transform.parent = transform;

            masterVolumePercent =  PlayerPrefs.GetFloat("master vol",1);     //볼륨 값을 가져옴 없으면 기본값 1
            sfxVolumePercent =  PlayerPrefs.GetFloat("sfx vol",1);
            musicVolumePercent =  PlayerPrefs.GetFloat("music vol",1);

        }
        
    }
    public void SetVolume(float volumePercent, AudioChannel channel){   //볼륨을 설정하는 매소드 
        switch(channel){                                                //스위치 구문 채널에따라 볼륨 퍼센트 설정
            case AudioChannel.Master:
                masterVolumePercent = volumePercent;
                break;
            case AudioChannel.Sfx:
                sfxVolumePercent = volumePercent;
                break;
            case AudioChannel.Music:
                musicVolumePercent = volumePercent;
                break;
        }
        musicSources.volume = musicVolumePercent * masterVolumePercent;

        PlayerPrefs.SetFloat("master vol",masterVolumePercent);         // 마스터 볼륨 퍼센트로 결정
        PlayerPrefs.SetFloat("sfx vol",sfxVolumePercent);
        PlayerPrefs.SetFloat("music vol",musicVolumePercent);
        PlayerPrefs.Save();                                             // 볼륨값을 저장
    }
    public void PlayMusic(AudioClip clip, float fadeDuration = 1){  // 음악을 플래이하는 메소드
        musicSources.clip = clip;                           // 재생에 필요한 클립을 받아옴
        musicSources.Play();                                //플레이
    }  
    public void PlaySound2D(string soundName){                  // 사운드이팩트를 사운드이름으로 받아서 플레이하는 메소드
        sfx2DSource.PlayOneShot(library.GetClipFromName(soundName),sfxVolumePercent * masterVolumePercent);     // 한번재생
    }

}