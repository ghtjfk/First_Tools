using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{
    private string Company;
    private int year;
    private string modelName;
    private bool isAccident;
    public void GasPedal()
    {

    }
    public void BreakePedal()
    {

    }
    public void AI_DriveMode()
    {

    }
    public void setYear(int year)
    {
        this.year = year;
    }
    public int getYear()
    {
        return year;
    }
    public void setCompany(string Company)
    {
        this.Company = Company;
    }
    public string getCompany()
    {
        return Company;
    }
    public void setmodelName(string modelName)
    {
        this.modelName = modelName;
    }
    public string getmodelName()
    {
        return modelName;
    }
    public void setisAccident(bool isAccident)
    {
        this.isAccident = isAccident;
    }
    public bool getisAccident()
    {
        return isAccident;
    }
}
