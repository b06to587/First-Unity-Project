using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos0;

    public Animator Ani;


    void Start()
    {
        //StartCoroutine(FadeIn());
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //복제한다. //'Bullet'을 'FirePos.transform.position' 위치에 'FirePos.transform.rotation' 회전값으로.
            if (WeaponChange.WeaponNum == 0)
            {
                Instantiate(Bullet, FirePos0.transform.position, FirePos0.transform.rotation);
                Ani.SetTrigger("Attack");
                AudioManager.instance.PlaySound2D("KnifeSound");
                Debug.Log("Swing Knife");
            }

            else if(WeaponChange.WeaponNum == 1)
            {
                Instantiate(Bullet, FirePos0.transform.position, FirePos0.transform.rotation);
                Debug.Log("Fire BitGun");
            }

            else if (WeaponChange.WeaponNum == 2)
            {
                Instantiate(Bullet, FirePos0.transform.position, FirePos0.transform.rotation);
                Instantiate(Bullet, FirePos0.transform.position, FirePos0.transform.rotation);
                Instantiate(Bullet, FirePos0.transform.position, FirePos0.transform.rotation);
                Debug.Log("Fire MachineGun");
            }

        }
    }

}
