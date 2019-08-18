using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange : MonoBehaviour
{
    public GameObject BitGun;
    public GameObject MashineGun;
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
            BitGun.SetActive(false);
            MashineGun.SetActive(true);
            Bullet.weaponDamage = Bullet.weaponMachineGunDamage;
            Bullet.weaponDistance = Bullet.weaponMachineGunDistance;
            WeaponNum = 1;
        }
        else if(WeaponNum == 1)
        {
            BitGun.SetActive(true);
            MashineGun.SetActive(false);
            Bullet.weaponDamage = Bullet.weaponBitGunDamage;
            Bullet.weaponDistance = Bullet.weaponBitGunDistance;
            WeaponNum = 0;
        }
        
    }
}

