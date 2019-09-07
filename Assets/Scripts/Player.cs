using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class Player : MonoBehaviour
{
    public Joystick joystick;
    [SerializeField]
    public bool notTouch = true;
    //움직이는 속도
    [SerializeField]
    private float walkSpeed;

    private Rigidbody myRigidBody;

    //카메라
    Camera viewCamera;
    private CapsuleCollider capsuleCollider; 
    // Start is called before the first frame update
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        myRigidBody = GetComponent<Rigidbody>(); 
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       
        GroundCheck();
    }
    void FixedUpdate()
    {
        Move();
    }

     //움직이는 함수
    private void Move(){
        Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;
        if (direction != Vector3.zero)
        myRigidBody.AddForce(direction * walkSpeed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    //바닥체크
    private void GroundCheck(){
        Ray ray = viewCamera.ScreenPointToRay (Input.mousePosition);
        Plane groundPlane = new Plane ( Vector3.up, Vector3.zero);
        float rayDistance;
        if(groundPlane.Raycast ( ray, out rayDistance)){
            Vector3 point = ray.GetPoint(rayDistance);
            Debug.DrawLine(ray.origin,point,Color.red);
            LookAt(point);
        }
    }   

    //바라보는 방향
    public void LookAt(Vector3 lookPoint){
        Vector3 heightCorrectedPoint = new Vector3(lookPoint.x, transform.position.y, lookPoint.z);
        transform.LookAt(heightCorrectedPoint);
    }
}
