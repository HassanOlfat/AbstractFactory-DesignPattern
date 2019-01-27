using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
     public enum Carsname
    {
        Volvo ,
        Benz
    }
    public interface ICar
    {
        string GetCarPrice();

    }

    public abstract class CarFactory
    {
        public static ICar GetCar(Carsname carName)
        {
            switch (carName)
            {
                case Carsname.Volvo:
                {
                    return new Volvo();
                }
                case Carsname.Benz:
                {
                    return new Benz();
                }
                default:
                    return null;

            }
        }
    }
    class Volvo : ICar
    {
        public string GetCarPrice()
        {
            return "$100";
        }
    }

    class Benz : ICar
    {
        public string GetCarPrice()
        {
            return "$200";
        }
    }
}
