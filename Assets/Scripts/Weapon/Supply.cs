using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supply : MonoBehaviour
{
    public Transform Transform;
    public GameObject Cube;

    
    void Start()
    {
        
    }

    float time = 0;
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 5)
        {
            time = 0;
            WeaponSupply();

            Debug.Log("Supply");
        }
    }

    public void WeaponSupply()
    {
        float supplyPosX = Random.Range(-18f, 18f);
        float supplyPosZ = Random.Range(-18f, 18f);
        Vector3 position = new Vector3(supplyPosX, 0.5f, supplyPosZ);
        Instantiate(Cube, position, Quaternion.identity);
    }

    
}

