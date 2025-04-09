using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamBo : Car
{
    void Start()
    {
        setCompany("KK");
        Debug.Log(getCompany());
        setYear(2002);
        Debug.Log(getYear());
        setmodelName("Lambo");
        Debug.Log(getmodelName());
        setisAccident(false);
        Debug.Log(getisAccident());
    }

    void Update()
    {
        
    }
}
