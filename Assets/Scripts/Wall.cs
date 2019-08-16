using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
   [SerializeField]
    public float Hp = 5; //Hp는 나중에 난수로다가 갔으면 좋겠네
    
    void Start()
    {
      
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")     //충돌상대 필터링
        {
            Hp -= Bullet.bulletDamage;
            Debug.Log(Hp);
        }

        if (Hp == 0)
        {
            Destroy(this.gameObject);
        }

    }

    /*
    public void Damage()
    {
        Hp -= Bullet.bulletDamage;
    }
    */
}
