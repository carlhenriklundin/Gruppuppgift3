using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment3
{
    static class UserInput
    {
        #region User interaction
        public static bool TryReadInt32(string question, int minInt, int maxInt, out int readInt)
        {
            readInt = 0;
            string sInput;
            do
            {
                Console.WriteLine($"{question} ({minInt}-{maxInt} or Q to quit)?");
                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out readInt) && readInt >= minInt && readInt <= maxInt)
                {
                    return true;
                }
                else if (sInput != "Q" && sInput != "q")
                {
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
            while ((sInput != "Q" && sInput != "q"));
            return false;
        }
        #endregion
    }
}
