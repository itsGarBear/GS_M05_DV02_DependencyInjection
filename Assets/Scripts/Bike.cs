using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
    private IEngine m_Engine;
    private IDriver m_Driver;

    public void SetEngine(IEngine engine)
    {
        m_Engine = engine;
    }
    public void SetDriver(IDriver driver)
    {
        m_Driver = driver;
    }

    public void StartEngine()
    {
        m_Engine.StartEngine();
        m_Driver.Control(this);
    }
    public void TurnLeft()
    {
        Debug.Log("The bike is turning left");
    }
    public void TurnRight()
    {
        Debug.Log("The bike is turning right");
    }
}
