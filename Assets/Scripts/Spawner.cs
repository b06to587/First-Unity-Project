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
public int wallMoveSpeed=100;

public int WallPosX =10; //월 생성 위치
    
    // Start is called before the first frame update
    void Start(){
        creatPentagon();
       
       
        
  
    }

    // Update is called once per frame
    void Update()
    {   
 WallMover();
        

    }
    public void creatPentagon(){
        for(int i=0; i<=4; i++){
            Wall.Add(Instantiate(prefabWall));
            identityWall.identitnumbe+=1;
            Wall[i].transform.parent=center.transform;
            center.transform.rotation=Quaternion.Euler(new Vector3(0,72*i,0));
            Wall[i].transform.position=new Vector3(WallPosX,0,0);

        }//end of for(0)
        for(int j = 0; j<=4; j++){
            Wall[j].transform.parent=null;
            Wall[j].transform.rotation=Quaternion.Euler(new Vector3(0,pentagon[j],0));
        }//end of for(1);
    }//end of createPentaagon()
    public void WallMover(){
        for(int i = 0; i<=4;i++){
       Vector3 velocity = Wall[i].transform.position-center.transform.position;
       Wall[i].transform.position-= velocity/wallMoveSpeed;
        }
    }
  
    }
