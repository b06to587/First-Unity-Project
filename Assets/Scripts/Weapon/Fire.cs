using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos0;
    public Transform FirePos1;
    public Transform FirePos2;

    public Animation Ani;


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

                Ani.Play("Swing");
                Instantiate(Bullet, FirePos0.transform.position, FirePos0.transform.rotation);
                Instantiate(Bullet, FirePos1.transform.position, FirePos1.transform.rotation);
                Instantiate(Bullet, FirePos2.transform.position, FirePos2.transform.rotation);
                Debug.Log("fire Knife");
                

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
