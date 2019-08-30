using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSet : MonoBehaviour
{
    
    [SerializeField]
    public bool readyToDestroy = false;
    // Update is called once per frame
    void Update()
    {
       CheckWall();
    }

    private void CheckWall(){
        for(int i = 0 ; i < 5; i++){
            if(transform.GetChild(i).GetComponentInChildren<Wall>().isDestroy)
                readyToDestroy = true;
               
        }
    }

}
