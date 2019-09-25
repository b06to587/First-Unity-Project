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
        Destroy(this.gameObject, 20);
    }

    public static bool supplyTouch = false;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            supplyTouch = true;
            myRenderer.material.color = touchColor;
            Destroy(this.gameObject, 1);
        }
    }

}