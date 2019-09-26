using System;
using System.Collections.Generic;
using System.Text;

namespace Shard.Helper
{
    public class ConsoleHelper
    {
        public static int? ReadInteger()
        {

            while (true)
            {
                var consoleValue = Console.ReadKey().KeyChar.ToString();
                if (int.TryParse(consoleValue, out var inputValue))
                {
                    return inputValue;
                }

                return null;
            }
        }
    }
}
