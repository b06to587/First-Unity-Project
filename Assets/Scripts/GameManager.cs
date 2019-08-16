using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool gameOver = false;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DeadCheck();
    }
    public void DeadCheck(){
        if(player.notTouch == true){
            gameOver = true;
        }
    }
}
