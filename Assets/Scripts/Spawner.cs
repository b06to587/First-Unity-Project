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
public int[] pentagon = new int[] {108,36,-36,-108,0};
    
    // Start is called before the first frame update
    void Start(){
  
        Wall.Add(Instantiate(prefabWall));
        identityWall.identitnumbe+=1;
        Wall[0].transform.parent=center.transform;
        center.transform.rotation=Quaternion.Euler(new Vector3(0,72*0,0));
        Wall[0].transform.position=new Vector3(10,0,0);
       

        Wall.Add(Instantiate(prefabWall));
        identityWall.identitnumbe+=1;
        Wall[1].transform.parent=center.transform;
        center.transform.rotation=Quaternion.Euler(new Vector3(0,72*1,0));
        Wall[1].transform.position=new Vector3(10,0,0);
     

        Wall.Add(Instantiate(prefabWall));
        identityWall.identitnumbe+=1;
        Wall[2].transform.parent=center.transform;
        center.transform.rotation=Quaternion.Euler(new Vector3(0,72*2,0));
        Wall[2].transform.position=new Vector3(10,0,0);
      

        Wall.Add(Instantiate(prefabWall));
        identityWall.identitnumbe+=1;
        Wall[3].transform.parent=center.transform;
        center.transform.rotation=Quaternion.Euler(new Vector3(0,72*3,0));
        Wall[3].transform.position=new Vector3(10,0,0);
      

        Wall.Add(Instantiate(prefabWall));
        identityWall.identitnumbe+=1;
        Wall[4].transform.parent=center.transform;
        center.transform.rotation=Quaternion.Euler(new Vector3(0,72*4,0));
        Wall[4].transform.position=new Vector3(10,0,0);

        Wall[0].transform.parent=null;
        Wall[1].transform.parent=null;
        Wall[2].transform.parent=null;
        Wall[3].transform.parent=null;
        Wall[4].transform.parent=null;

        Wall[0].transform.rotation=Quaternion.Euler(new Vector3(0,pentagon[0],0));
        Wall[1].transform.rotation=Quaternion.Euler(new Vector3(0,pentagon[1],0));
        Wall[2].transform.rotation=Quaternion.Euler(new Vector3(0,pentagon[2],0));
        Wall[3].transform.rotation=Quaternion.Euler(new Vector3(0,pentagon[3],0));
        Wall[4].transform.rotation=Quaternion.Euler(new Vector3(0,pentagon[4],0));

       
    }

    // Update is called once per frame
    void Update()
    {   
     
  
   
        

    }

  
    }
