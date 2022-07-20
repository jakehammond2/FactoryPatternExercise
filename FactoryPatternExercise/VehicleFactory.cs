using System;
namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        static VehicleFactory()
        {
        }

        public static IVehicle GetVehicle(int numOfTires)
        { 

            switch (numOfTires)

            {

               case 4:
                return new Car();
            
               case 2:
                return new Motorcycle();

               case 18:
                return new BigRig();


             }

            return new Car(); 
               
               
        }
    }
}
 
