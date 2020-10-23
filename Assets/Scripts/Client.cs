using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pattern.DependencyInjection
{
   public class Client : MonoBehaviour
   {
        public Bike m_PlayerBike;
        public Bike m_AndroidBike;
        public Bike m_RedneckBike;
        public Bike m_SoftwareBike;

        public Text text; 
        private void Awake()
        {
            text.text = "Press A to turn LEFT and D to turn RIGHT";

            //Human + Jet
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();

            m_PlayerBike.SetEngine(jetEngine);
            m_PlayerBike.SetDriver(humanDriver);
            m_PlayerBike.StartEngine();
            
            //AI + Nitro
            IEngine nitroEngine = new NitroEngine();
            IDriver aiDriver = new AndroidDriver();

            m_PlayerBike.SetEngine(nitroEngine);
            m_PlayerBike.SetDriver(aiDriver);
            m_PlayerBike.StartEngine();
            
            //Redneck + Watermill
            IEngine waterMillEngine = new WaterMillEngine();
            IDriver redneckDriver = new RedneckDriver();

            m_PlayerBike.SetEngine(waterMillEngine);
            m_PlayerBike.SetDriver(redneckDriver);
            m_PlayerBike.StartEngine();
            
            //Software + Game
            IEngine gameEngine = new GameEngine();
            IDriver softwareDriver = new SoftwareDriver();

            m_PlayerBike.SetEngine(gameEngine);
            m_PlayerBike.SetDriver(softwareDriver);
            m_PlayerBike.StartEngine();
        }
    }
}

