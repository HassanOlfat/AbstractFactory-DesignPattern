using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public enum Bicyclesname
    {
        Trek,
        Benz
    }
    public interface Ibicycle
    {
        string GetbicyclePrice();

    }

    public abstract class BicycleFactory
    {
        public static Ibicycle GetBicycle(Bicyclesname carName)
        {
            switch (carName)
            {
                case Bicyclesname.Trek:
                {
                    return new Trek();
                }
                case Bicyclesname.Benz:
                {
                    return new Specialized();
                }
                default:
                    return null;

            }
        }
    }

    class Trek : Ibicycle
    {
        public string GetbicyclePrice()
        {
            return "$100";
        }
    }

    class Specialized : Ibicycle
    {
        public string GetbicyclePrice()
        {
            return "$200";
        }
    }
}
