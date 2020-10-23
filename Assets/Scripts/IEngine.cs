using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEngine
{
    void StartEngine();
}

public class JetEngine : IEngine
{
    public void StartEngine()
    {
        ActivateJetStream();
        Debug.Log("Engine started");
    }

    private void ActivateJetStream()
    {
        Debug.Log("The jet stream is activated");
    }
}
public class NitroEngine : IEngine
{
    public void StartEngine()
    {
        OpenNitroValve();
        Debug.Log("Engine started");
    }

    private void OpenNitroValve()
    {
        Debug.Log("The nitro valve is open");
    }
}
public class GameEngine : IEngine
{
    public void StartEngine()
    {
        ArchitectGameEngine();
        Debug.Log("Engine started");
    }

    private void ArchitectGameEngine()
    {
        Debug.Log("The game engine has been architected");
    }
}
public class WaterMillEngine : IEngine
{
    public void StartEngine()
    {
        HydroPower();
        Debug.Log("Engine started");
    }

    private void HydroPower()
    {
        Debug.Log("The watermill is being hydropowered");
    }
}
