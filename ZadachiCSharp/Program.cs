using System;
namespace ZadachiCSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            int allPer;

            Building build1 = new Building();
            Building build2 = new Building();
            Building build3 = new Building();

            build1.Init(9, 2000, 150);
            build2.Init(5, 1500, 120);
            build3.Init(16, 3500, 250);

            build1.Info();
            build2.Info();
            build3.Info();

            allPer = build1.maxPersons() + build2.maxPersons() + build3.maxPersons();

            Console.WriteLine("Максимальное количество человек во всех зданиях: " + allPer);

            Console.WriteLine("Площадь на одного человека в здании 1: " + build1.AreaPerson() + " м^2");
            Console.WriteLine("Площадь на одного человека в здании 2: " + build2.AreaPerson() + " м^2");
            Console.WriteLine("Площадь на одного человека в здании 3: " + build3.AreaPerson() + " м^2");

            Console.ReadKey();

        }
    }
}
