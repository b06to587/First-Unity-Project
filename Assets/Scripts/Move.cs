using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    public Rigidbody knifeRigidbody;

    public Transform knifeTransform;

    int speed = 250;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void KnifeTransform()
    {
        knifeTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))                    
        {
            knifeRigidbody.AddForce(0, 0, speed); 
        }

        if (Input.GetKey(KeyCode.A))
        {
            knifeRigidbody.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            knifeRigidbody.AddForce(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            knifeRigidbody.AddForce(speed, 0, 0);
        }

    }
}
