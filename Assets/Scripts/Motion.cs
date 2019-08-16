using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public Transform attackMotion;
    
    public GameObject Athame_nife;
    

    // Start is called before the first frame update
    void Start()
    {
        

    }
    /*
    void Update()
    {
        if (Input.GetMouseButton(0))
            StartCoroutine(weaponAttack());
        
    }

    
    IEnumerator weaponAttack()
    {

        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 40, 0));
        transform.rotation = targetRotation;

        yield return new WaitForSeconds(1f);
        transform.Rotate(new Vector3(0, -40, 0));
    }
    */

}
