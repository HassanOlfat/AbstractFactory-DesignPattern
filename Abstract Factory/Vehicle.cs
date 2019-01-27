using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public interface IVehicleFactory
    {
        //Ibicycle GetBicycle(Bicyclesname bicycleName);
        //ICar GetCar(Carsname carName);
        Vehicle ConvertVehicle(Vehicle.VehicleName carName, string model);
    }
   
    public abstract class Vehicle
    {
        public enum VehicleName
        {
            Volvo, Benz,
            Specialized, Trek
        }
        private string Input;
        public Vehicle(string input)
        {
            Input = input;
        }

       

        public abstract string GetPrice();
        

       
    }
}
