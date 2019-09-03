using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public static bool gameOver = false;

    public void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Wall")     
        {
            gameOver = true;
        }
    }
    
}
