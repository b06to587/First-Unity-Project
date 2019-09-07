using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static float weaponKnifeDamage = 0.8f;
    public static float weaponKnifeDistance = 0.047f;
    public static float weaponBitGunDamage = 0.8f;
    public static float weaponBitGunDistance = 0.1f;
    public static float weaponMachineGunDamage = 0.8f;
    public static float weaponMachineGunDistance = 0.05f;

    public static float weaponDamage = weaponKnifeDamage;
    public static float weaponDistance = weaponKnifeDistance;

    void Start()
    {
        
    }
    
    void Update()
    {
        //프레임마다 오브젝트를 로컬좌표상에서 앞으로 1의 힘만큼 날아가라
        
        transform.Translate(Vector3.forward * 0.8f);
        Destroy(this.gameObject, weaponDistance);
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Wall")     
        {
            Destroy(this.gameObject);
        }

    }





}
