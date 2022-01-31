using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            CarBuilder carBuilder = new CarBuilder();
            director.commandNewCar(carBuilder);
            Car car = carBuilder.getResult();

            ManualBuilder manualBuilder = new ManualBuilder();
            director.commandNewCar(manualBuilder);
            Manual manual = manualBuilder.getResult();

            PrintMethod(car, manual);


            CarBuilder mountainCarBuilder = new CarBuilder();
            director.commandMountainCar(mountainCarBuilder);
            Car mountainCar = mountainCarBuilder.getResult();

            ManualBuilder mountainManualBuilder = new ManualBuilder();
            director.commandMountainCar(mountainManualBuilder);
            Manual mountainManual = mountainManualBuilder.getResult();

            PrintMethod(mountainCar, mountainManual);
        }

        public static void PrintMethod(Car car, Manual manual)
        {
            Console.WriteLine("*** Car Engine ***");
            Console.WriteLine("-Car engine: {0}",car._engine._capacity);
            Console.WriteLine("-Engine model: {0}", manual._engine._model);
            Console.WriteLine("-Engine description: {0}\n", manual._engine._description);

            Console.WriteLine("*** GPS option ***");
            Console.WriteLine("-GPS model: {0}",car._gps._model);
            Console.WriteLine("-GPS description: {0}", manual._gps._description);
            Console.WriteLine("-GPS instalation: {0}\n", manual._gps._installation);

            Console.WriteLine("*** Car seats ***");
            Console.WriteLine("-Seats number: {0}", car._seats._numerSeats);
            Console.WriteLine("-Seats material: {0}",manual._seats._material);
            Console.WriteLine("-Seats description: {0}\n", manual._seats._description);

            Console.WriteLine("*** Trip Computer option ***");
            Console.WriteLine("-Trip Computer model: {0}", car._tripComputer._model);
            Console.WriteLine("-Trip Computer description: {0}", manual._tripComputer._description);
            Console.WriteLine("-Trip Computer type: {0}",manual._tripComputer._type);

            Console.WriteLine("\n-----------------------------------------------------------\n");
        }
    }
}
