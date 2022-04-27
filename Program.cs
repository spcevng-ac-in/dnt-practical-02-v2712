using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight of parcel: ");
            //String data = Console.ReadLine();

            //int weight Convert.ToInt32(data);

            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of distance ");
            int distance = Convert.ToInt32(Console.ReadLine());

            int charge = 0;

            if (distance <= 188)
            {

                charge = 50;
            }
            else if (distance <= 200)
                charge = 65;
            else if (distance <= 300)
                charge = 90;
            else
                charge = 120;

            int total_amount = weight * charge;

            Console.WriteLine("total amount " + total_amount);

            Console.Read();
        }
    }
}