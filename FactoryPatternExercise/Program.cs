using FactoryPatternExercise;

Console.WriteLine("Type in how many wheels on on your vehicle");

int VehicleType = Convert.ToInt32(Console.ReadLine());

IVehicle myVehicle = VehicleFactory.GetVehicle(VehicleType);

Console.WriteLine(myVehicle);

