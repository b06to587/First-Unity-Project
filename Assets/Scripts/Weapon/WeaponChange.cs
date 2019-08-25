﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange : MonoBehaviour
{
    public GameObject Knife;
    public GameObject BitGun;
    public GameObject MachineGun;
    // Start is called before the first frame update   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Change();
        }
    }


    public static int WeaponNum = 0;
    public void Change()
    {
        if(WeaponNum == 0)
        {
            Knife.SetActive(false);
            BitGun.SetActive(true);
            //MachineGun.SetActive(false);
            Bullet.weaponDamage = Bullet.weaponBitGunDamage;
            Bullet.weaponDistance = Bullet.weaponBitGunDistance;
            WeaponNum = 1;
        }
        else if(WeaponNum == 1)
        {
            //Knife.SetActive(false);
            BitGun.SetActive(false);
            MachineGun.SetActive(true);
            Bullet.weaponDamage = Bullet.weaponMachineGunDamage;
            Bullet.weaponDistance = Bullet.weaponMachineGunDistance;
            WeaponNum = 2;
        }

        else if (WeaponNum == 2)
        {
            Knife.SetActive(true);
            //BitGun.SetActive(false);
            MachineGun.SetActive(false);
            Bullet.weaponDamage = Bullet.weaponKnifeDamage;
            Bullet.weaponDistance = Bullet.weaponKnifeDistance;
            WeaponNum = 0;
        }
    }
}

