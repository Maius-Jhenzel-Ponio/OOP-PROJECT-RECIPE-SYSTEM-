using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recipe System");

            Console.Write("Enter your Reference Code to access: ");

            string userinput = Console.ReadLine();

            if (Account.Login(userinput))
            {
                Menu.Show(userinput);

                User.PorkSinigang();
                Instructions.PorkSinigangInstructions();

                User.ChickenAdobo();
                Instructions.ChickenAdoboInstructions();

                User.PorkAdobo();
                Instructions.PorkAdoboInstructions();

                User.Karekare();
                Instructions.KarekareInstructions();

                User.PorkMenudo();
                Instructions.PorkMenudoInstructions();

                User.Logout();
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}

