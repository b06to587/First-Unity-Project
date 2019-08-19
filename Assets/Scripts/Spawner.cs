using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject center;
    public GameObject prefabWall;
    public Wall identityWall;
    public int SpawnerToidentitynumber=0;
    public List<GameObject> Wall = new List<GameObject>(); 
    public Quaternion ori = Quaternion.Euler(new Vector3(0,0,0));
    public Quaternion plus = Quaternion.Euler(new Vector3(0,72,0));
    public int[] pentagon = new int[5] {108,36,-36,-108,180};
    public int wallMoveSpeed=1000;

    public int WallPosX =10; //월 생성 위치

    public int goalWall=4;//생성되어야 할 벽
    public int nowWall =0;// 생성되어 있는 벽
    
    // Start is called before the first frame update
    void Start(){
        creatPentagon();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetButtonDown("Fire2")){creatPentagon();
        nowWall+=5;
        goalWall+=5;
        }
        WallMover();
        WallShrink();
   
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
        for(int i = 0; i<=goalWall;i++){
       
            Vector3 velocity = Wall[i].transform.position-center.transform.position;
            Wall[i].transform.position-= velocity/wallMoveSpeed;
     
        }
    }

    private void WallShrink(){
        float rate =  1-((float)1/wallMoveSpeed);
        for (int i = 0; i <=goalWall; i++)
        {
            Wall[i].transform.localScale *= rate;
        }
    }
  
}
