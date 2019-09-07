using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSet : MonoBehaviour
{  
    [SerializeField]
    public static bool readyToDestroy = false;
    
    public GameObject explosion;
    // Update is called once per frame
    void Update()
    {
        CheckWall();
        DestroyWall();
    }

    private void CheckWall(){
        for(int i = 0 ; i < 5; i++)
        {
            if(transform.GetChild(i).GetComponentInChildren<Wall>().isDestroy)
            {
                readyToDestroy = true; 
            }
        }   
    }

    private void DestroyWall(){
        if(readyToDestroy)
        {
            for(int i = 0 ; i < 5; i++)
            {
                Instantiate(explosion, transform.GetChild(i).GetComponentInChildren<Wall>().transform.position, transform.GetChild(i).GetComponentInChildren<Wall>().transform.rotation);
                Destroy(transform.GetChild(i).GetComponentInChildren<Wall>().gameObject);
                Destroy(this.gameObject);
                readyToDestroy = false;
            }     
        }
    }

}
