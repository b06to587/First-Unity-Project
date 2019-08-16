using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Point;
    public GameObject Wall;
  
    public GameObject[] Points;
    public GameObject standardPoint;

    public float wallLength;
    public List<GameObject> howManyPoin = new List<GameObject>();
     
    private int[] pointAngels = {36,324,252,0,108};

    
    // Start is called before the first frame update
    void Start(){
        for (int i = 0; i < 6; i++)
            howManyPoin.Add(Points[i]);
        pointMaker(5);
    }

    // Update is called once per frame
    void Update()
    {    
        wallMove();       
    }

    private void wallMove(){
        for (int i = 0; i < 5; i++){
            Vector3 move =  Points[i].transform.GetChild(0).position-standardPoint.transform.position;
            Points[i].transform.GetChild(0).position -= move/500;
            Points[i].transform.GetChild(1).position -= move/500;
            Vector3 length = new Vector3(0,0,0);
            length=Points[0].transform.GetChild(0).position-Points[1].transform.GetChild(0).position;
            wallLength = length.magnitude;
            Points[i].transform.GetChild(1).localScale=new Vector3(wallLength,1,1); 
        }    
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
            howManyPoin[i].transform.rotation=Quaternion.Euler(originalLotation+plusLotation*i);
            Instantiate(Point,new Vector3(10,0,0),Quaternion.identity).transform.parent=howManyPoin[i].transform;
            Instantiate(Wall,new Vector3(10,0,0),Quaternion.Euler(0,pointAngels[i],0)).transform.parent=howManyPoin[i].transform;
            howManyPoin[i].transform.rotation=Quaternion.Euler(originalLotation+plusLotation); 
            howManyPoin[i].transform.GetChild(1).localScale =new Vector3(wallLength,1,1);
            howManyPoin[i].transform.GetChild(1).localRotation=Quaternion.Euler( new Vector3(0,pointAngels[i],0));
        }
    }
}