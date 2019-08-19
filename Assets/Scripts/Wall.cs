using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    
    public float Hp = 5; //Hp는 나중에 난수로다가 갔으면 좋겠네
    public int identitnumbe=0;
    public GameManager gameManager;
    void Start()
    {

    }
    
    
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bullet")     //충돌상대 필터링
        {
            Hp -= Bullet.weaponDamage;
            Debug.Log(Hp);
        }

        if (Hp <= 0)
        {
            this.gameObject.GetComponent<Renderer>().enabled=false;
        }

    }

    /*
    public void Damage()
    {
        Hp -= Bullet.bulletDamage;
    }
    */
}