using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet0;
    public GameObject Bullet1;
    public GameObject Bullet2;

    public Transform KnifeFirePos0;
    public Transform KnifeFirePos1;
    public Transform BitGunFirePos0;    
    public Transform MachineGunFirePos0;

    public Animator Ani;


    public void FireButton()
    {
         //복제한다. //'Bullet'을 'FirePos.transform.position' 위치에 'FirePos.transform.rotation' 회전값으로.
            if (WeaponChange.WeaponNum == 0)
            {
                Instantiate(Bullet2, KnifeFirePos0.transform.position, KnifeFirePos0.transform.rotation);
                Instantiate(Bullet2, KnifeFirePos1.transform.position, KnifeFirePos1.transform.rotation);
                Ani.SetTrigger("Attack");
                AudioManager.instance.PlaySound2D("KnifeSound");
                Debug.Log("Swing Knife");
            }

            else if(WeaponChange.WeaponNum == 1)
            {
                Instantiate(Bullet0, BitGunFirePos0.transform.position, BitGunFirePos0.transform.rotation);
                Debug.Log("Fire BitGun");
                AudioManager.instance.PlaySound2D("GunSound");
            }

            else if (WeaponChange.WeaponNum == 2)
            {
                Instantiate(Bullet1, MachineGunFirePos0.transform.position, MachineGunFirePos0.transform.rotation);
                Instantiate(Bullet1, MachineGunFirePos0.transform.position, MachineGunFirePos0.transform.rotation);
                Instantiate(Bullet1, MachineGunFirePos0.transform.position, MachineGunFirePos0.transform.rotation);
                Debug.Log("Fire MachineGun");
            }
    }
}
