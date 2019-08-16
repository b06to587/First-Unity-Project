using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static float bulletDamage = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 오브젝트를 로컬좌표상에서 앞으로 1의 힘만큼 날아가라
        transform.Translate(Vector3.forward * 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")     //충돌상대 필터링
        {
            Destroy(this.gameObject);
        }

    }

}
