using System;

namespace ZadachiCSharp
{
    class Building
    {
        public int floor;
        public double square;
        public int neighbours;

        public void Init(int floors,int sq,int neigh)
        {
            floor = floors;
            square = sq;
            neighbours = neigh;
        }

        public double AreaPerson()
        {
            double sqper;
            sqper = square / neighbours;
            return sqper;
        }

        public int maxPersons()
        {
            int minSQ = 8;
            int maxP;
            maxP = Convert.ToInt32(Math.Round(square / minSQ));
            return maxP;
        }

        public void Info()
        {
            Console.WriteLine("Этажей в здании: " + floor);
            Console.WriteLine("Площадь здания: " + square);
            Console.WriteLine("Жильцов: " + neighbours); 
        }

    }
}
