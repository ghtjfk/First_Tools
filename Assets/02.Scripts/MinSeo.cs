using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinSeo : Human
{
    public override void Eat()
    {
        Debug.Log("����");
    }
    void Start()
    {
        myName = "���μ�";
        Debug.Log(myName);
        Eat();
    }

    void Update()
    {
        
    }
}
