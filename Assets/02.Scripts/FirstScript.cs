using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int hp = 100;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            hp -= 20;
            if (hp <= 0)
            {
                print("게임오버");
            }
            else
            {
                Debug.Log("현재 체력은: " + hp + " 입니다.");
            }
        }
    }
}
//마우스 버튼: Input.GetMouseButton(0 or 1);         누르고 있을 때 동안.        0은 좌클릭, 1이 우클릭
//              Input.GetMouseButtonDown(0 or 1);         눌렀을 때.
//              Input.GetMouseButtonUp(0 or 1);           뗐을 때.

//키보드 감지:   Input.GetKey(**);                   누르고 있을 때 동안.
//              Input.GetKeyDown(**);               눌렀을 때
//             Input.GetKeyUp(**);                  뗐을 때.


