using PaveldejimasND._2;
using PaveldejimasND.AI_ND;
using System;

namespace PaveldejimasND
{


    // 1. Turėtų būti klasė Animal
    //Ją paveldėti šuo ir katė.Animal turėtų turėti bent porą sąvybių ir porą metodų.
    //Sukurkite metodą kuris priims tiek Cat tiek Dog ir padarykite kažkokį funkcionalumą jo viduje.


    //// 2. Sukurkite ransporto priemon3, tada sukurkite vaikus sausumos ir juru ir oro transporote priemones kurios paveldi TP
    //Ir tada jas dar tur4t7 paveld4ti konkrecios priemones pvz sunkvežemis automobilis.
    //Būtinai kiekviena klasė turėtų turėti bent po dvi sąvybes ir iš senelio paveldėtą bent vieną metodą.
    //Būtinai turi būti konstruktoriai visose klasėse ir, bent viename anūke ar vaike perrašytas virtualus metodas su žodžiu override

    internal class Program
    {
        static void Main(string[] args)
        {


            //1

            //Dog dog = new Dog(10, "Baki", 5, "Red");
            //Cat cat = new Cat(5, "Mici", 2, 8);

            //Console.WriteLine($"DailyFood:{dog.CalculateDailyFoodGrams()}g Age: {dog.getAge()}");

            //Console.WriteLine($"DailyFood:{cat.CalculateDailyFoodGrams()}g Age: {cat.getAge()}");

            // 2

            //Car firstCar = new Car("Toyota supra", 500000, 200, 5, 4, "diesel");
            //Console.WriteLine(firstCar.Name);
            //Console.WriteLine("time to 100: " + firstCar.TimeTo100());
            //Console.WriteLine($"{firstCar.MaxSpeed}km/h {firstCar.MaxSpeedinfo()}miles/h");

            //Plane firstPlane = new Plane(500, 2, "Boeing 737", 1000000, 850, 3);
            //Console.WriteLine("\n" + firstPlane.Name);
            //Console.WriteLine("time to 100: " + firstPlane.TimeTo100());
            //Console.WriteLine($"{firstPlane.MaxSpeed}km/h {firstPlane.MaxSpeedinfo()} machs");

            //Boat firstBoat = new Boat(10, 0.5, "Titan", 300000, 30, 1);
            //Console.WriteLine("\n" + firstBoat.Name);
            //Console.WriteLine("time to 100: " + firstBoat.TimeTo100());
            //Console.WriteLine($"{firstBoat.MaxSpeed}km/h {firstBoat.MaxSpeedinfo()} knots");

            //AI ND

            //Smartphone s = new Smartphone(true, "Samsung", "S24", 50);
            //Console.WriteLine(s.Info());
        }
    }
}
