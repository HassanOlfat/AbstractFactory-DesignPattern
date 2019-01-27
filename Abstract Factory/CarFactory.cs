using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    // public enum Carsname
    //{
    //    Volvo ,
    //    Benz
    //}
    //public interface ICar
    //{
    //    string GetPrice();

    //}

    public  class CarFactory : IVehicleFactory
    {
        public  Vehicle ConvertVehicle(Vehicle.VehicleName carName , string model)
        {
            switch (carName)
            {
                case Vehicle.VehicleName.Volvo:
                {
                    return new Volvo(model);
                }
                case Vehicle.VehicleName.Benz:
                {
                    return new Benz(model);
                }
                default:
                    return null;

            }
        }

       
    }
   public  class Volvo : Vehicle
    {
        public override string GetPrice()
        {
            return "$100";

        }

        public Volvo(string input) : base(input)
        {
        }

       
    }

    public class Benz : Vehicle
    {
        public override  string GetPrice()
        {
            return "$200";

        }

        public Benz(string input) : base(input)
        {
        }

    }
}
