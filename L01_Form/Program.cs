#region Author
// Author: Pavel Usov
#endregion

#region Homework
/*
 * 1. Write programm: "Form"
 * 2. Calculate Mass Body Index
 */
#endregion

using System;

namespace L01_Form
{
    class Program
    {
        static float getBodyMassIndex(int weightByKilo = 0, float heightByMeters = 1)
        {

            return weightByKilo / (heightByMeters * heightByMeters);
        }

        static void HomeWork01_02()
        {
            float ONE_HUNDRED_METERS = 100;
            string firstName, lastName;
            int age, height, weight;
            float heightByMeters;

            Console.WriteLine("-= Homework 1 =-");
            Console.WriteLine("Enter your first name:");

            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");

            lastName = Console.ReadLine();

            Console.WriteLine("Enter your age:");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height by cm:");

            height = int.Parse(Console.ReadLine());
            heightByMeters = (float)height / (float)ONE_HUNDRED_METERS;


            Console.WriteLine("Enter your weight by kilo:");

            weight = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {firstName} {lastName}. Age: {age}. Height: {height}. Weight: {weight}. ");

            Console.WriteLine("-= Homework 2 =-");

            Console.WriteLine($"Your body mass index: {getBodyMassIndex(weight, heightByMeters)}");
        }

        static float getDistance(float x1, float x2, float y1, float y2)
        {
            float powX = (float)Math.Pow(x2 - x1, 2);
            float powY = (float)Math.Pow(y2 - y1, 2);
            return (float)Math.Sqrt(powX + powY);
        }

        static void HomeWork03()
        {
            const string Format = "Distance between points {0:F2}";

            float x1, x2, y1, y2;

            Console.WriteLine("\n\n-= Homework 3 =-");

            Console.WriteLine("Enter coordinates of point 1:");

            Console.Write("x1 = ");

            x1 = float.Parse(Console.ReadLine());

            Console.Write("y1 = ");

            y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinates of point 2:");

            Console.Write("x2 = ");

            x2 = float.Parse(Console.ReadLine());

            Console.Write("y2 = ");

            y2 = float.Parse(Console.ReadLine());

            Console.WriteLine(Format, getDistance(x1, x2, y1, y2));


        }

        static void Main(string[] args)
        {
            HomeWork01_02();

            HomeWork03();

            Console.ReadKey();
        }
    }
}
