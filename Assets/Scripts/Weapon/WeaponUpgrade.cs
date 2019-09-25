using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrade : MonoBehaviour
{


    void Start()
    {

    }


    void Update()
    {
        /* 
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Distance Upgrade");
            DistanceUpgrade();
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Damage Upgrade");
            DamageUpgrade();
        }
        */
    }


    public void DamageUpgrade()
    {
        if (WeaponChange.WeaponNum == 0)
        {
            Bullet.weaponKnifeDamage += 0.25f;
            Bullet.weaponDamage = Bullet.weaponKnifeDamage;
        }
        else if (WeaponChange.WeaponNum == 1)
        {
            Bullet.weaponBitGunDamage += 0.25f;
            Bullet.weaponDamage = Bullet.weaponBitGunDamage;
        }
        else if (WeaponChange.WeaponNum == 2)
        {
            Bullet.weaponMachineGunDamage += 0.25f;
            Bullet.weaponDamage = Bullet.weaponMachineGunDamage;
        }
    }

    public void DistanceUpgrade()
    {
        if (WeaponChange.WeaponNum == 0)
        {
            Bullet.weaponKnifeDistance += 0.08f;
            Bullet.weaponDistance = Bullet.weaponKnifeDistance;
        }
        else if (WeaponChange.WeaponNum == 1)
        {
            Bullet.weaponBitGunDistance += 0.05f;
            Bullet.weaponDistance = Bullet.weaponBitGunDistance;
        }
        else if (WeaponChange.WeaponNum == 2)
        {
            Bullet.weaponMachineGunDistance += 0.05f;
            Bullet.weaponDistance = Bullet.weaponMachineGunDistance;
        }

    }

    
}
