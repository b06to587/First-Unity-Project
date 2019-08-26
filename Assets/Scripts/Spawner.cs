using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector2 secondsBetweenSpawnsMinMax;  //벽 생성 최소 최대 속도
    private float nextSpawnTime;
    [SerializeField]
    private GameObject prefabWallSet;

    void Start(){
        StartCoroutine(createMorePentagon());
    }

    // Update is called once per frame
    void Update()
    {   
        //Debug.Log(wallMoveSpeed);
      
        WallDestorychecker();
    }

    IEnumerator createMorePentagon(){
        while(true){
            GameObject wallPrefab = Instantiate(prefabWallSet,new Vector3(1.3f,3f,1.1f), Quaternion.identity) as GameObject;
            float secondsBetweenSpawns = Mathf.Lerp(secondsBetweenSpawnsMinMax.y,secondsBetweenSpawnsMinMax.x, Difficulty.GetDifficultyPercent());
            nextSpawnTime = secondsBetweenSpawns;
            yield return new WaitForSeconds(nextSpawnTime);
        }
    }

    private void WallDestorychecker(){
        foreach (var item in GameObject.FindGameObjectsWithTag("WallSet"))
        {
            if(item.GetComponent<WallSet>().readyToDestroy)
            Destroy(item.gameObject);
        }
            
    }
}