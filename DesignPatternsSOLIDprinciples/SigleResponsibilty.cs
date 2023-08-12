using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSOLIDprinciples
{
    /// <summary>
    /// a class should not be loaded with multiple responsibilities and a single 
    /// responsibility should not be spread across 
    /// multiple classes or mixed with other responsibilities
    /// </summary>


    //wrong implementation, by mixing car service function implementaion with open and close gate responsibilty
    public class GarageService
    {
        public void OpenGate()
        {

        }
        public void CloseGate()
        {

        }
        public void CarService()
        {

        }
    }
    //correct implemenation by refactoring the above class by introducing an interface cantains open and close gate function definition
    public class GarageStation
    {
        IGarageUtility _garageUtility;
        public GarageStation(IGarageUtility garageUtility)
        {
            _garageUtility = garageUtility;

        }
        public void OpenForService()
        {
            _garageUtility.OpenGate();
        }
        public void DoService()
        {
            //implementatoin here
        }
        public void CloseGate()
        {
            _garageUtility.CloseGate();
        }
    }


    public class GarageStationUtility : IGarageUtility
    {
        public void CloseGate()
        {
            //do implementation here
        }

        public void OpenGate()
        {
            //do implementation here
        }
    }
    public interface IGarageUtility
    {
        void OpenGate();
        void CloseGate();
    }

   
}
