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
                print("���ӿ���");
            }
            else
            {
                Debug.Log("���� ü����: " + hp + " �Դϴ�.");
            }
        }
    }
}
//���콺 ��ư: Input.GetMouseButton(0 or 1);         ������ ���� �� ����.        0�� ��Ŭ��, 1�� ��Ŭ��
//              Input.GetMouseButtonDown(0 or 1);         ������ ��.
//              Input.GetMouseButtonUp(0 or 1);           ���� ��.

//Ű���� ����:   Input.GetKey(**);                   ������ ���� �� ����.
//              Input.GetKeyDown(**);               ������ ��
//             Input.GetKeyUp(**);                  ���� ��.


