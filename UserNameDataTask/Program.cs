using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada oma eesnime;
            //programm palub kasutajal sisestada number 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi;
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimene täht;
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta number 1-3:");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    reversedName(userName);
                    break;
                case '2':
                    firstLetter(userName);
                    break;
                case '3':
                    nameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void reversedName(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void firstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void nameLength(string userInput)
        {
            Console.WriteLine($"Sinu eesnimi on {userInput.Length} sümbolit pikk.");
        }
    }
}
