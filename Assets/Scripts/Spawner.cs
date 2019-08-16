using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Point;
    public GameObject Wall;
  
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;
    public GameObject Point5;
    public GameObject Point6;
    public GameObject standardPoint;

    public float wallLength;
    public List<GameObject> howManyPoin = new List<GameObject>();
     public List<GameObject> howManyWall = new List<GameObject>();
      public List<GameObject> Wallcont = new List<GameObject>();
     public GameObject MovingWall;

    
    // Start is called before the first frame update
    void Start()
    {
        howManyPoin.Add(Point1);
        howManyPoin.Add(Point2);
        howManyPoin.Add(Point3);
        howManyPoin.Add(Point4);
        howManyPoin.Add(Point5);
        howManyPoin.Add(Point6);
/* 
    howManyWall.Add(Wall1);
    howManyWall.Add(Wall2);
    howManyWall.Add(Wall3);
    howManyWall.Add(Wall4);
    howManyWall.Add(Wall5);
*/
    Vector3 wnat = new Vector3(1,1,20);
    Quaternion aRotation = Point1.transform.rotation;

      Quaternion bRotation = Point2.transform.rotation;
      Quaternion targetRotation = Quaternion.Lerp(aRotation, bRotation, 0.5f);
    pointMaker(5);
 
   


    }

    // Update is called once per frame
    void Update()
    {    
        Vector3 move1 =  Point1.transform.GetChild(0).position-standardPoint.transform.position;
        Point1.transform.GetChild(0).position -= move1/500;
        Point1.transform.GetChild(1).position -= move1/500;

         Vector3 move2 =  Point2.transform.GetChild(0).position-standardPoint.transform.position;
        Point2.transform.GetChild(0).position -= move2/500;
        Point2.transform.GetChild(1).position -= move2/500;

         Vector3 move3 =  Point3.transform.GetChild(0).position-standardPoint.transform.position;
        Point3.transform.GetChild(0).position -= move3/500;
        Point3.transform.GetChild(1).position -= move3/500;

         Vector3 move4 =  Point4.transform.GetChild(0).position-standardPoint.transform.position;
        Point4.transform.GetChild(0).position -= move4/500;
        Point4.transform.GetChild(1).position -= move4/500;

         Vector3 move5 =  Point5.transform.GetChild(0).position-standardPoint.transform.position;
        Point5.transform.GetChild(0).position -= move5/500;
        Point5.transform.GetChild(1).position -= move5/500;

        Vector3 length = new Vector3(0,0,0);
        length=Point1.transform.GetChild(0).position-Point2.transform.GetChild(0).position;
        wallLength = length.magnitude;
        Point1.transform.GetChild(1).localScale=new Vector3(wallLength,1,1);
      
        Point2.transform.GetChild(1).localScale=new Vector3(wallLength,1,1);
        
            Point3.transform.GetChild(1).localScale=new Vector3(wallLength,1,1);
        
              Point4.transform.GetChild(1).localScale=new Vector3(wallLength,1,1);
              
                Point5.transform.GetChild(1).localScale=new Vector3(wallLength,1,1);
              
        Debug.Log(wallLength);
        /* 
      Point1.transform.GetChild(1).rotation=Quaternion.Euler(new Vector3(0,-36,0));
      Point2.transform.GetChild(1).rotation=Quaternion.Euler(new Vector3(0,-324,0));
          Point3.transform.GetChild(1).rotation=Quaternion.Euler(new Vector3(0,-252,0));
          Point4.transform.GetChild(1).rotation=Quaternion.Euler(new Vector3(0,0,0));
            Point5.transform.GetChild(1).rotation=Quaternion.Euler(new Vector3(0,-108,0));
            */
    //시작
///WallMove(Point1,Point2,Wall1,0);
//WallMove(Point2,Point3,Wall2,1);
//WallMove(Point3,Point4,Wall3,2);
//WallMove(Point4,Point5,Wall4,3);
//WallMove(Point5,Point1,Wall5,4);
 //끝
 

        
    }

    private void pointMove(GameObject point){
         Vector3 move =  point.transform.position-standardPoint.transform.position;
        point.transform.position -= move/100;
    }
    
    private void WallMove(GameObject Point1,GameObject Point2,GameObject Wall,int rotation){

          Vector3 a = new Vector3(0,0,0);
        Vector3 b = new Vector3(0,0,0);
        float hight = 0;
   
       // a = Point1.transform.GetChild(0).position- standardPoint.transform.position;
       // b = Point2.transform.GetChild(0).position - standardPoint.transform.position;
        hight = (a.magnitude*b.magnitude)/wallLength;
        Debug.Log(hight+"!!!!!!!!!");

        //Wall.transform.GetChild(0).localScale=new Vector3(1,1,wallLength);
        /* 
        float wantX=wallLength*Mathf.Sqrt(3)/2;
       Wall.transform.GetChild(0).position = new Vector3(wantX,0,0);
    */
    }


    private void pointMaker(int NumberOfPoint){//3이상 6이하
    float figure = 360/NumberOfPoint;
    Vector3 originalLotation = new Vector3(0f,0f,0f);
    Vector3 plusLotation = new Vector3(0f,figure,0f);

    if(NumberOfPoint<3 || NumberOfPoint>6){
        Debug.Log("Error");
        return;
    }
  
    for(int i = 0; i <5; i++){
          int k =0;
        switch (i){
            case 0:
            k = 36;
            break;
            case 1:
            k=324;
            break;
            case 2:
            k=252;
            break;
            case 3:
            k=0;
            break;
            case 4:
            k=108;
            break;
        }
        howManyPoin[i].transform.rotation=Quaternion.Euler(originalLotation+plusLotation*i);
        Instantiate(Point,new Vector3(10,0,0),Quaternion.identity).transform.parent=howManyPoin[i].transform;
        Instantiate(Wall,new Vector3(10,0,0),Quaternion.Euler(0,k,0)).transform.parent=howManyPoin[i].transform;
        howManyPoin[i].transform.rotation=Quaternion.Euler(originalLotation+plusLotation); 
        
      

        howManyPoin[i].transform.GetChild(1).localScale =new Vector3(wallLength,1,1);
        howManyPoin[i].transform.GetChild(1).localRotation=Quaternion.Euler( new Vector3(0,k,0));
   
      
    }
}//end of pointmaker








    private void Wallmaker(){
    Vector3 originalLotation = new Vector3(0f,0f,0f);
    Vector3 plusLotation = new Vector3(0f,32f,0f);
        for(int i =0; i<5; i++){
          
            Instantiate(Wall).transform.parent=howManyPoin[i].transform;
         
        }
    }//end of WallMaker

        private void newWallMaker(int NumberOfPoint){//3이상 6이하
    float figure = 360/NumberOfPoint;
    Vector3 originalLotation = new Vector3(0f,0f,0f);
    Vector3 plusLotation = new Vector3(0f,figure,0f);

    if(NumberOfPoint<3 || NumberOfPoint>6){
        Debug.Log("Error");
        return;
    }
  
    for(int i = 0; i <NumberOfPoint; i++){
        int k =0;
        switch (i){
            case 0:
            k = 36;
            break;
            case 1:
            k=324;
            break;
            case 2:
            k=252;
            break;
            case 3:
            k=0;
            break;
            case 4:
            k=108;
            break;
        }
        howManyWall[i].transform.rotation=Quaternion.Euler(originalLotation+plusLotation*i);
        Instantiate(Wall,new Vector3(10,0,0),Quaternion.identity).transform.parent=howManyPoin[i].transform;
        howManyWall[i].transform.rotation=Quaternion.Euler(originalLotation+plusLotation); 
    }
}//end of newWall Maker
}