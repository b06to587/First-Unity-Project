using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject center;
    public Vector2 secondsBetweenSpawnsMinMax;  //벽 생성 최소 최대 속도
    public GameObject prefabWall;
    public Wall identityWall;
    public List<GameObject> Wall = new List<GameObject>(); 
    public int[] pentagon = new int[5] {108,36,-36,-108,180};
    private float wallMoveSpeed;
    private float nextSpawnTime;
    [SerializeField]
    private Vector2 wallMoveSpeedMinMax;

    public int WallPosX =10; //월 생성 위치

    public int goalWall=4;//생성되어야 할 벽
    public int nowWall =0;// 생성되어 있는 벽
    
    // Start is called before the first frame update
    void Start(){
        StartCoroutine(createMorePentagon());
    }

    // Update is called once per frame
    void Update()
    {   
        //Debug.Log(wallMoveSpeed);
        WallMover();
        WallShrink();
        WallDestorychecker();
    }
    IEnumerator createMorePentagon(){
        while(true){
            creatPentagon();
            nowWall = nowWall +5;
            goalWall = goalWall + 5;
            float secondsBetweenSpawns = Mathf.Lerp(secondsBetweenSpawnsMinMax.y,secondsBetweenSpawnsMinMax.x, Difficulty.GetDifficultyPercent());
            nextSpawnTime = secondsBetweenSpawns;
            yield return new WaitForSeconds(nextSpawnTime);
        }
    }
    public void creatPentagon(){
        for(int i=nowWall; i<=goalWall; i++){
            int k = i %5;
            Wall.Add(Instantiate(prefabWall) as GameObject);
            identityWall.identitnumbe+=1;
            Wall[i].transform.parent=center.transform;
            center.transform.rotation=Quaternion.Euler(new Vector3(0,72*k,0));
            Wall[i].transform.position=new Vector3(WallPosX,0,0);
        }//end of for(0)

        for(int j = nowWall; j<=goalWall; j++){
            int k = j %5;
            Wall[j].transform.parent=null;
            Wall[j].transform.rotation=Quaternion.Euler(new Vector3(0,pentagon[k],0));
        }//end of for(1);
    }//end of createPentaagon()
    public void WallMover(){
        int Size = Wall.Count;
        wallMoveSpeed = Mathf.Lerp(wallMoveSpeedMinMax.x, wallMoveSpeedMinMax.y , Difficulty.GetDifficultyPercent());
        for(int z = 0; z< Size;z++){
            Vector3 velocity = Wall[z].transform.position - center.transform.position;
            Wall[z].transform.position -= velocity/wallMoveSpeed;
        }
    }

    private void WallShrink(){
        int Size = Wall.Count;
        float rate =  ((float)1/wallMoveSpeed);
        for (int i = 0; i <Size; i++){
            Wall[i].transform.localScale -= new Vector3(rate,0,rate);
        }
    }
    private void WallDestorychecker(){
        for(int i = 0; i<Wall.Count; i++){
            if(Wall[i].GetComponent<Wall>().isDestroy == true){
                int big = i/5;
                for(int j = 0; j<=5*big+4; j++){
                    Wall[j].SetActive(false);
                }
            }    
        }
    }
}