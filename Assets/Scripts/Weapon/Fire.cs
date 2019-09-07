using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Bullet1;
    public Transform FirePos0;
    public Transform FirePos1;

    public Animator Ani;


    public void FireButton()
    {
         //복제한다. //'Bullet'을 'FirePos.transform.position' 위치에 'FirePos.transform.rotation' 회전값으로.
            if (WeaponChange.WeaponNum == 0)
            {
                Instantiate(Bullet, FirePos0.transform.position, FirePos0.transform.rotation);
                Instantiate(Bullet, FirePos1.transform.position, FirePos1.transform.rotation);
                Ani.SetTrigger("Attack");
                AudioManager.instance.PlaySound2D("KnifeSound");
                Debug.Log("Swing Knife");
            }

            else if(WeaponChange.WeaponNum == 1)
            {
                Instantiate(Bullet1, FirePos0.transform.position, FirePos0.transform.rotation);
                Debug.Log("Fire BitGun");
                AudioManager.instance.PlaySound2D("GunSound");
            }

            else if (WeaponChange.WeaponNum == 2)
            {
                Instantiate(Bullet1, FirePos0.transform.position, FirePos0.transform.rotation);
                Instantiate(Bullet1, FirePos0.transform.position, FirePos0.transform.rotation);
                Instantiate(Bullet1, FirePos0.transform.position, FirePos0.transform.rotation);
                Debug.Log("Fire MachineGun");
            }
    }
}
