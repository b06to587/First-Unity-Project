using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class joystickBackGround : MonoBehaviour
{
    // Start is called before the first frame update

public Transform Stick;

private Vector3 StickFirstPos;
private Vector3 JoyVec;

private float Radius;

void Start(){
    Radius = GetComponent<RectTransform>().sizeDelta.y*0.5f;
    StickFirstPos = Stick.transform.position;

    float Can = transform.parent.GetComponent<RectTransform>().localScale.x;
    Radius *=Can;
}

public void Drag(BaseEventData _Data){
     PointerEventData Data = _Data as PointerEventData;
        Vector3 Pos = Data.position;
        
        // 조이스틱을 이동시킬 방향을 구함.(오른쪽,왼쪽,위,아래)
        JoyVec = (Pos - StickFirstPos).normalized;
 
        // 조이스틱의 처음 위치와 현재 내가 터치하고있는 위치의 거리를 구한다.
        float Dis = Vector3.Distance(Pos, StickFirstPos);
        
        // 거리가 반지름보다 작으면 조이스틱을 현재 터치하고 있는곳으로 이동. 
        if (Dis < Radius)
            Stick.position = StickFirstPos + JoyVec * Dis;
        // 거리가 반지름보다 커지면 조이스틱을 반지름의 크기만큼만 이동.
        else
            Stick.position = StickFirstPos + JoyVec * Radius;
}
   public void DragEnd()
    {
        Stick.position = StickFirstPos; // 스틱을 원래의 위치로.
        JoyVec = Vector3.zero;          // 방향을 0으로.
    }
}
