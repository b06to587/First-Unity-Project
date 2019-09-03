using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public static bool gameOver = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")     
        {
            gameOver = true;
        }
    }
    
}
