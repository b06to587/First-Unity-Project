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
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("Distance Upgrade");
            DistanceUpgrade();
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Damage Upgrade");
            DamageUpgrade();
        }
    }


    public void DistanceUpgrade()
    {
        Bullet.weaponDistance += 0.05f;
    }

    public void DamageUpgrade()
    {
        Bullet.weaponDamage += 0.25f;
    }
}
