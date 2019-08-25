using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupplyDestroy : MonoBehaviour
{
    public Color touchColor;
    private Renderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    float supplyEnchantTime = 0;
    float supplyTouch = 0;
    void Update()
    {
        //if()
        //Destroy(this.gameObject, );
        
        supplyEnchantTime += Time.deltaTime;
        if(supplyTouch == 0)
        {
            Destroy(this.gameObject, 10);
        }
        else if(supplyTouch == 1)
        {
            //SupplyEnchantTime();
            if(supplyEnchantTime > 5)
            {
                Bullet.weaponDamage -= 10;
                supplyTouch = 3;
            }
        }
        else if(supplyTouch == 3)
        {
            Destroy(this.gameObject, 5);
        }
        

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            supplyTouch = 1;
            myRenderer.material.color = touchColor;
            supplyEnchantTime = 0;

            //Destroy(this.gameObject);
            Bullet.weaponDamage += 10;
        }
    }

    private void SupplyEnchantTime()
    {
        supplyEnchantTime = 0;
    }

}