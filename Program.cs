using System;

namespace Day13_Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" maximum Number from given integer");
            int output = UC1_int_max.MaximumIntegerNumber(50,60,70);
            Console.WriteLine(output);

            Console.WriteLine(" maximum Number from given float values");
            double doubleoutput = UC2_float_max.MaximumFloatNumber(121.5,67.5,55.5);
            Console.WriteLine(doubleoutput);

            Console.WriteLine(" maximum Number from given string");
            string strigoutput = UC3_string_max.MaximumStringNumber("38", "67", "99");
            Console.WriteLine(strigoutput);

        }
    }
}
