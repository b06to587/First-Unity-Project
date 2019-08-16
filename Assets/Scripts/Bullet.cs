using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static float weaponBitGunDamage = 0.5f;
    public static float weaponBitGunDistance = 0.1f;
    public static float weaponMachineGunDamage = 1f;
    public static float weaponMachineGunDistance = 0.05f;

    void Start()
    {
        
    }

    public static float weaponDamage = weaponBitGunDamage;
    public static float weaponDistance = weaponBitGunDistance;


    void Update()
    {
        //프레임마다 오브젝트를 로컬좌표상에서 앞으로 1의 힘만큼 날아가라
        
        transform.Translate(Vector3.forward * 2f);
        Destroy(this.gameObject, weaponDistance);
    }



    

}
