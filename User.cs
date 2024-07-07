﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    internal class User
    {
        public static void PorkSinigang()
        {
            Console.Write("How many poeple would eat your sinigang?: ");
            int num = Convert.ToInt16 (Console.ReadLine());

            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.85} cup/s Water");
            Console.WriteLine($"{num * 0.10} kg/s Pork");
            Console.WriteLine($"{num * 0.15} cup/s Diced Onion");
            Console.WriteLine($"{num * 0.35} cup/s Sliced Tomato");
            Console.WriteLine($"{num * 0.15} cup/s sliced Finger Chili");
            Console.WriteLine($"{num * 0.10} cup/s Sitaw");
            Console.WriteLine($"{num * 0.10} cup/s Radish");
            Console.WriteLine($"{num * 0.10} cup/s Okra");
            Console.WriteLine($"{num * 0.15} sachet/s Sinigang Mix");
            Console.WriteLine($"{num * 0.15} cup/s Kang kong");

            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the steps and procedure");
            Console.WriteLine("2. Logout");
            Console.Write("Select option by typing 1 and 2: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            if (num1 == 1) 
            {
                Instructions.PorkSinigangInstructions();
            }
            else if (num1 == 2) 
            { 
                Console.WriteLine("Logging out...");
            }
            else 
            { 
                Console.WriteLine("Invalid Input...");
            }

        }

        public static void ChickenAdobo()
        {
            Console.Write("How many poeple would eat your Chicken Adobo?: ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.25} cup/s Water");
            Console.WriteLine($"{num * 0.15} kg/s Chicken");
            Console.WriteLine($"{num * 0.15} cube/s Chicken Cube");
            Console.WriteLine($"{num * 0.05} cup/s Soy Sauce");
            Console.WriteLine($"{num * 0.35} pc/s Bay Leaf");
            Console.WriteLine($"{num * 0.10} tbsp/s Peppercorn");
            Console.WriteLine($"{num * 0.15} head/s Toasted Garlic");
            Console.WriteLine($"{num * 0.35} tbsp/s Vegetable Oil");

            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the steps and procedure");
            Console.WriteLine("2. Logout");
            Console.Write("Select option by typing 1 and 2: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            if (num2 == 1)
            {
                Instructions.ChickenAdoboInstructions();
            }
            else if (num2 == 2)
            {
                Console.WriteLine("Logging out...");
            }
            else
            {
                Console.WriteLine("Invalid Input...");
            }

        }
        public static void PorkAdobo()
        {
            Console.Write("How many poeple would eat your Pork Adobo?: ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.25} cup/s Water");
            Console.WriteLine($"{num * 0.15} g/s Pork Shoulder");
            Console.WriteLine($"{num * 0.25} sachet/s Oyster Sauce");
            Console.WriteLine($"{num * 0.25} tbsp/s Vegetable Oil");
            Console.WriteLine($"{num * 0.5} pc/s Bay Leaf");
            Console.WriteLine($"{num * 0.25} tbsp/s Peppercorn");
            Console.WriteLine($"{num * 0.25} head/s Garlic");
            Console.WriteLine($"{num * 0.75} tbsp/s White Vinegar");

            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the steps and procedure");
            Console.WriteLine("2. Logout");
            Console.Write("Select option by typing 1 and 2: ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            if (num3 == 1)
            {
                Instructions.PorkAdoboInstructions();
            }
            else if (num3 == 2)
            {
                Console.WriteLine("Logging out...");
            }
            else
            {
                Console.WriteLine("Invalid Input...");
            }
        }
        public static void Karekare()
        {
            Console.Write("How many poeple would eat your Kare-kare?: ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.15} kg/s Beef Oxtail");
            Console.WriteLine($"{num * 0.35} sachet/s Seasonings");
            Console.WriteLine($"{num * 0.15} tbsp/s Vegetable Oil");
            Console.WriteLine($"{num * 0.15} pc/s Bay Leaf");
            Console.WriteLine($"{num * 0.10} tbsp/s Peppercorn");
            Console.WriteLine($"{num * 0.10} head/s Garlic");
            Console.WriteLine($"{num * 0.10} pc/s Onion");
            Console.WriteLine($"{num * 0.15} tbsp/s Anatto with iye");
            Console.WriteLine($"{num * 0.05} cup/s Ground Rice");
            Console.WriteLine($"{num * 0.05} cup/s Peanuts");
            Console.WriteLine($"{num * 0.85} pc/s Sitaw");
            Console.WriteLine($"{num * 0.15} bunch/es Pechay");
            Console.WriteLine($"{num * 0.40} pc/s Eggplant");
            Console.WriteLine($"{num * 0.10} cup/s Bagoong Alamang");


            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the steps and procedure");
            Console.WriteLine("2. Logout");
            Console.Write("Select option by typing 1 and 2: ");
            int num4 = Convert.ToInt16(Console.ReadLine());

            if (num4 == 1)
            {
                Instructions.KarekareInstructions();
            }
            else if (num4 == 2)
            {
                Console.WriteLine("Logging out...");
            }
            else
            {
                Console.WriteLine("Invalid Input...");
            }
        }
        public static void PorkMenudo() 
        {
            Console.Write("How many poeple would eat your Menudo?: ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("The list of ingredients are: ");
            Console.WriteLine($"{num * 0.40} cup/s Water");
            Console.WriteLine($"{num * 0.10} kg/s Pork Shoulder");
            Console.WriteLine($"{num * 0.15} pc/s Carrot");
            Console.WriteLine($"{num * 0.15} pc/s Potato");
            Console.WriteLine($"{num * 0.55} sachet/s Seasoning");
            Console.WriteLine($"{num * 1} clove/s Garlic");
            Console.WriteLine($"{num * 0.15} pc/s Onion");
            Console.WriteLine($"{num * 0.15} pc/s Red Bell Pepper"); 
            Console.WriteLine($"{num * 0.15} pc/s Green Bell Pepper");
            Console.WriteLine($"{num * 0.15} pc/s Bay Leaf");
            Console.WriteLine($"{num * 0.15} cup/s Tomato Sauce");
            Console.WriteLine($"{num * 0.05} tbsp/s Ground Pepper");
            Console.WriteLine($"{num * 0.15} tbsp/s Brown Sugar");

            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Continue to the steps and procedure");
            Console.WriteLine("2. Logout");
            Console.Write("Select option by typing 1 and 2: ");
            int num5 = Convert.ToInt16(Console.ReadLine());

            if (num5 == 1)
            {
                Instructions.PorkMenudoInstructions();
            }
            else if (num5 == 2)
            {
                Console.WriteLine("Logging out...");
            }
            else
            {
                Console.WriteLine("Invalid Input...");
            }
        }
        public static void Logout() 
        {
            Console.WriteLine("Logging Out...");
        }
    }
       
}