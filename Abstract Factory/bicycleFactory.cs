using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    //public enum Bicyclesname
    //{
    //    Trek,
    //    Specialized
    //}
    //public interface Ibicycle
    //{
    //    string GetPrice();

    //}

    public  class BicycleFactory : IVehicleFactory
    {
        public Vehicle ConvertVehicle(Vehicle.VehicleName bicycleName, string model) { 
            switch (bicycleName)
            {
                case Vehicle.VehicleName.Trek:
                {
                    return new Trek(model);
                }
                case Vehicle.VehicleName.Specialized:
                {
                    return new Specialized(model);
                }
                default:
                    return null;
            }
        }

       

    }

   
    public class Trek : Vehicle
    {
        public override string GetPrice()
        {
            return "$100";

        }

        public Trek(string input) : base(input)
        {
        }


    }

    public class Specialized : Vehicle
    {
        public override string GetPrice()
        {
            return "$200";

        }

        public Specialized(string input) : base(input)
        {
        }

    }
}
