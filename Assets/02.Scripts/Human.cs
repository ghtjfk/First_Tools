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
        print("³È³È ¸Ô´Â´Ù.");
    }
    public void Sleep()
    {
        print("ÄðÄð ÀÜ´Ù.");
    }
    public void PowerPush()
    {
        print("Èû²¯ Àå ³» ¹°ÁúÀ» ¹Ð¾î³½´Ù");
    }

}
