using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public string myName;
    private int myAge;
    private float myHeight;
    bool isSolo;
    public virtual void Eat()
    {
        print("�ȳ� �Դ´�.");
    }
    public void Sleep()
    {
        print("���� �ܴ�.");
    }
    public void PowerPush()
    {
        print("���� �� �� ������ �о��");
    }

}
