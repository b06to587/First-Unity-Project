using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public static bool gameOver = false;
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(5,10,5),3);
    }
    public void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Wall")     
        {
            gameOver = true;
            AudioManager.instance.PlaySound2D("cristal");
        }
    }
    
}
