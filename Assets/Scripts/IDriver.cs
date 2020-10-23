using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDriver
{
    void Control(Bike bike);
}

public class HumanDriver : IDriver
{
    private Bike m_bike;
    public void Control(Bike bike)
    {
        m_bike = bike;
        Debug.Log("Human Controlled");
    }
}
public class AndroidDriver : IDriver
{
    private Bike m_bike;
    public void Control(Bike bike)
    {
        m_bike = bike;
        Debug.Log("AI Controlled");
    }
}
public class RedneckDriver : IDriver
{
    private Bike m_bike;
    public void Control(Bike bike)
    {
        m_bike = bike;
        Debug.Log("YeeeeeeeHAWWWWWWW");
    }
}
public class SoftwareDriver : IDriver
{
    private Bike m_bike;
    public void Control(Bike bike)
    {
        m_bike = bike;
        Debug.Log("Please update your drivers");
    }
}

