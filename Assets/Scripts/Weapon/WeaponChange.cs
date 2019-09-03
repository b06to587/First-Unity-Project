using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange : MonoBehaviour
{
    public GameObject Knife;
    public GameObject BitGun;
    public GameObject MachineGun;
    
    float weaponEnchantTime = 0;
    void Update()
    {
        weaponEnchantTime += Time.deltaTime;

        if (SupplyDestroy.supplyTouch == true)
        {
            if(WeaponNum < 2)
            {
                WeaponNum += 1;
                Change2();
                SupplyDestroy.supplyTouch = false;
            }
            else if(WeaponNum >= 2)
            {
                Change2();
                SupplyDestroy.supplyTouch = false;
            }
        }

        if(WeaponNum == 0 )
        {
            weaponEnchantTime = 0;
        }

        if(weaponEnchantTime > 5 && WeaponNum == 1)
        {
            WeaponNum -= 1;
            Change2();
        }

        if(weaponEnchantTime > 5 && WeaponNum == 2)
        {
            WeaponNum -= 2;
            Change2();
        }
    }

    public static int WeaponNum = 0;

    public void Change2()
    {
        if(WeaponNum == 0)
        {
            Knife.SetActive(true);
            BitGun.SetActive(false);
            MachineGun.SetActive(false);
            Bullet.weaponDamage = Bullet.weaponKnifeDamage;
            Bullet.weaponDistance = Bullet.weaponKnifeDistance;
            weaponEnchantTime = 0;
        }
        else if(WeaponNum == 1)
        {
            Knife.SetActive(false);
            BitGun.SetActive(true);
            MachineGun.SetActive(false);
            Bullet.weaponDamage = Bullet.weaponBitGunDamage;
            Bullet.weaponDistance = Bullet.weaponBitGunDistance;
            weaponEnchantTime = 0;
        }

        else if (WeaponNum == 2)
        {
            Knife.SetActive(false);
            BitGun.SetActive(false);
            MachineGun.SetActive(true);
            Bullet.weaponDamage = Bullet.weaponMachineGunDamage;
            Bullet.weaponDistance = Bullet.weaponMachineGunDistance;
            weaponEnchantTime = 0;
        }
    }

}

