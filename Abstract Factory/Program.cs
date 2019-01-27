using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory v = VehicleAbstractFactoty.CreateFactory(VehicleAbstractFactoty.VehicleFactotyType.Car);
            Vehicle v2 = v.ConvertVehicle(Vehicle.VehicleName.Benz,"220");

            Console.WriteLine(v.GetType());
            Console.WriteLine(v2.GetType() + " : " +v2.GetPrice());
            Console.ReadKey();
        }
    }
}
