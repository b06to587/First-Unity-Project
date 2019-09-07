using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSet : MonoBehaviour
{  
    [SerializeField]
    public static bool readyToDestroy = false;
    public int combo=0;
    public static int gamseScore= 0;
    public static int activeCombo;
   public Material compareRed;
    
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
              
                if(transform.GetChild(i).GetComponent<MeshRenderer>().material.name== "Color Red (Instance)"){
                   combo+=1;
                   Debug.Log("몇배수점수인지"+combo);
                    
                }
                
                Instantiate(explosion, transform.GetChild(i).GetComponentInChildren<Wall>().transform.position, transform.GetChild(i).GetComponentInChildren<Wall>().transform.rotation);
                AudioManager.instance.PlaySound2D("WallExplosion");
                Destroy(transform.GetChild(i).GetComponentInChildren<Wall>().gameObject);
                Destroy(this.gameObject);
               
                readyToDestroy = false;

            }
            activeCombo= combo; 
            gamseScore +=20*activeCombo;    
        }
    }

}
