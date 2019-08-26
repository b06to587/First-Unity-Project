using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField]
    private GameObject center;
    public System.Action<Wall> OnWallReturn;
    public float Hp = 5; //Hp는 나중에 난수로다가 갔으면 좋겠네
    public int PickRandomHp;
    public bool isDestroy =false;
    public Material Red;
    public Material Orange;
    public Material Yellow;
    public Material Green;
    public Material Blue;
    public Material Navy;
    public Material Purple;
    public int[] rainbow = new int[7] {0,1,2,3,4,5,6};
    [SerializeField]
    private Vector2 wallMoveSpeedMinMax;
    private float wallMoveSpeed;
    void Start()
    {
        giveToWallHpType();
    }

    void Update()
    {
        WallMove();
        WallShrink();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bullet")     //충돌상대 필터링
        {
            Hp -= Bullet.weaponDamage;
            Debug.Log(Hp);
        }

        if (Hp <= 0)
        {
            switch(PickRandomHp){
            case 0:
            isDestroy= true;
            break;

            case 1:
            PickRandomHp-=1;
            Hp=1;
            gameObject.GetComponent<MeshRenderer>().material= Red;
            break;

            case 2:
            PickRandomHp-=1;
            Hp=2;
            gameObject.GetComponent<MeshRenderer>().material= Orange;
            break;

            case 3:
            PickRandomHp-=1;
            Hp=3;
            gameObject.GetComponent<MeshRenderer>().material= Yellow;
            break;

            case 4:
            PickRandomHp-=1;
            Hp=4;
            gameObject.GetComponent<MeshRenderer>().material= Green;
            break;

            case 5:
            PickRandomHp-=1;
            Hp=5;
            gameObject.GetComponent<MeshRenderer>().material= Blue;
            break;
            
            case 6:
            PickRandomHp-=1;
            Hp=6;
            gameObject.GetComponent<MeshRenderer>().material= Navy;
            break;
            }
        }
    }

    public void giveToWallHpType(){
       PickRandomHp= Random.Range(0, 7);
       switch(PickRandomHp){
           case 0 : 
           gameObject.GetComponent<MeshRenderer>().material= Red;
           Hp= 1;
            break;         
           case 1 :
            gameObject.GetComponent<MeshRenderer>().material= Orange;
            Hp=2;
            break;
           case 2 :
            gameObject.GetComponent<MeshRenderer>().material= Yellow;
            Hp=3;
            break;
           case 3 :
            gameObject.GetComponent<MeshRenderer>().material= Green;
            Hp=4;
            break;
           case 4 : 
           gameObject.GetComponent<MeshRenderer>().material= Blue;
           Hp=5;
            break;
           case 5 :
            gameObject.GetComponent<MeshRenderer>().material= Navy;
            Hp=6;
             break;
           case 6 :
            gameObject.GetComponent<MeshRenderer>().material= Purple;
            Hp=7;
             break;

       }

    }

    public void WallMove(){
        wallMoveSpeed = Mathf.Lerp(wallMoveSpeedMinMax.x, wallMoveSpeedMinMax.y , Difficulty.GetDifficultyPercent());
        Vector3 velocity = transform.position - center.transform.position;  
        transform.position -= velocity/wallMoveSpeed;
    }

    private void WallShrink(){
        float rate =  ((float)1/wallMoveSpeed);
        if(transform.localScale.z > 4)
        transform.localScale -= new Vector3(0,0,rate * 10.5f);
    }

}