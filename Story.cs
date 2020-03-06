using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Testing_Github
{
    class Program
    {
        public static void Main(string[] args)
        {
            string CharacterName = "";

            Console.WriteLine("GAME 1!");
            Console.ReadKey();

            Console.WriteLine("Good Morning. How are you?");
            Console.ReadKey();

            Console.WriteLine("Remind me... What is your name again?");           
            CharacterName = Console.ReadLine();

            Console.WriteLine("Ah that's right! " + CharacterName + "! What brings you to these parts?.");
            Console.Read();


        }
    }
}