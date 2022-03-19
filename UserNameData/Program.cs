﻿using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada oma eesnime;
            //programm kuvab kasutaja eesnime pikkust;
            //programm kuvab kasutaja eessnime esimest tähte;
            //programm kuvab kasutaja eesnime tagurpidi;
            //main meetodis ei tohi olla rohkem kui kolm rida koodi

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu eesnimi on {userInput.Length} sümbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
