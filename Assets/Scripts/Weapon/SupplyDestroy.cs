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
        Destroy(this.gameObject, 10);
    }

    float supplyEnchantTime = 0;
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            myRenderer.material.color = touchColor;
            supplyEnchantTime = 0;

            //Destroy(this.gameObject);
            Bullet.weaponDamage += 10;

        }
    }

}