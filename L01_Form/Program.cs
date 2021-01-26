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

        static void Main(string[] args)
        {
            float ONE_HUNDRED_METERS = 100;
            string firstName, lastName;
            int age, height, weight;
            float heightByMeters;

            Console.WriteLine("Write your first name:");

            firstName = Console.ReadLine();

            Console.WriteLine("Write your last name:");

            lastName = Console.ReadLine();

            Console.WriteLine("Write your age:");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Write your height by cm:");

            height = int.Parse(Console.ReadLine());
            heightByMeters = (float)height / (float)ONE_HUNDRED_METERS;


            Console.WriteLine("Write your weight by kilo:");

            weight = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {firstName} {lastName}. Age: {age}. Height: {height}. Weight: {weight}. ");

            Console.WriteLine($"Your body mass index: {getBodyMassIndex(weight, heightByMeters)}");

        }
    }
}
