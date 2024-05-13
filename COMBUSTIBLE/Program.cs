using System;

namespace COMBUSTIBLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto1 = new Automovil("Ford", "MY30527", "Scape", "Verde", 44, 10); // 10 km por galon
            Automovil auto2 = new Automovil("Toyota", "MY78787", "Corolla", "Negro", 55, 15); // 10 km por galon

            auto1.Drive(200); //km
            auto2.Drive(300); //km

            Console.WriteLine("¿Auto 1 puede conducir 600 km? " + (auto1.PuedeConducir(600) ? "Sí" : "No"));
            Console.WriteLine("¿Auto 2 puede conducir 400 km? " + (auto2.PuedeConducir(400) ? "Sí" : "No"));


  

            Console.ReadLine();
        }
    }
}
