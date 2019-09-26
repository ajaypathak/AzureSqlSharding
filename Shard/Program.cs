using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shard.Helper;

namespace Shard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("***    Welcome to Azure SQL Sharding Sample    ***");
            Console.WriteLine("***********************************************************");
            Console.WriteLine();

            Configuration.InitializeConfiguration();


            ShowMenu();
        }

        private static void ShowMenu()
        {
            bool continueLoop = true;
            do
            {
                continueLoop = GetMenuChoiceAndExecute();


            } while (continueLoop);
        }

        private static bool GetMenuChoiceAndExecute()
        {
            while (true)
            {
                Console.WriteLine("\nEnter an option [1-6] and press ENTER: ");
                var option = ConsoleHelper.ReadInteger();
                switch (option)
                {
                    case 1:
                        return true;
                        break;
                    case 6:
                        return false;

                }
            }
        }
    }
}
