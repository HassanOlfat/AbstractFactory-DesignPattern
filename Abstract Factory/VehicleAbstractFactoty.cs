using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
  public abstract  class  VehicleAbstractFactoty
    {
        public enum VehicleFactotyType
        {
            Bicycle, Car
        }
        public static IVehicleFactory CreateFactory(VehicleFactotyType input)
        {
            switch (input)
            {
                case VehicleFactotyType.Car:
                    return new CarFactory();
                case VehicleFactotyType.Bicycle:
                    return new BicycleFactory();
               
                default:
                    throw new NotImplementedException();

            }
        }

       
    }
}
