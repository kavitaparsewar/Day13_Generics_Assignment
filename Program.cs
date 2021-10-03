using System;

namespace Day13_Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            //region Refactor1
            //int checkInt3 = Refactor1<int>.MaximumIntNumber(97, 568, 200);
            //Console.WriteLine("Maximum Number:" + checkInt3);
            //float checkFloat3 = Refactor1<float>.MaxFloatNumber(55.5f, 75.47f, 98.65f);
            //Console.WriteLine("Maximum Number:" + checkFloat3);
            //string checkString3 = Refactor1<string>.MaximumStringNumber("35", "63", "72");
            //Console.WriteLine("Maximum Number:" + checkString3);
            //endregion Refactor1



            //#region Refactor2
            //int checkInt = Refactor2<int>.MaximumIntNumber(6, 10, 500);
            //Console.WriteLine("Maximum int  Number:" + checkInt);
            //float checkFloat = Refactor2<float>.MaxFloatNumber(32.7f, 175.55f, 30.55f);
            //Console.WriteLine("Maximum float Number:" + checkFloat);
            //string checkString = Refactor2<string>.MaximumStringNumber("34", "66", "100");
            //Console.WriteLine("Maximum string Number:" + checkString);
            //#endregion Refactor2


            //#region UC1
            //Console.WriteLine(" maximum Number from given integer");
            //int output = UC1_int_max.MaximumIntegerNumber(50,60,70);
            //Console.WriteLine(output);
            //#endregion UC1


            //#region UC2
            //Console.WriteLine(" maximum Number from given float values");
            //double doubleoutput = UC2_float_max.MaximumFloatNumber(121.5,67.5,55.5);
            //Console.WriteLine(doubleoutput);
            //endregion UC2


            //#region UC3
            //Console.WriteLine(" maximum Number from given string");
            //string strigoutput = UC3_string_max.MaximumStringNumber("38", "67", "99");
            //Console.WriteLine(strigoutput);
            //endregion UC3


            //#region UC4_more_than_3_parameters
            //int[] intArray1 = { 977, 86, 500, 550, 236 };
            //UC4_more_than_3_parameter<int> checkInt1 = new UC4_more_than_3_parameter<int>(intArray1);
            //int i = checkInt1.MaxValue(intArray1);
            //Console.WriteLine(i);

            //float[] floatArray1 = { 3.6f, 7.5f, 45.2f, 85.89f, 56.2f };
            //UC4_more_than_3_parameter<float> checkFloat1 = new UC4_more_than_3_parameter<float>(floatArray1);
            //float f = checkFloat1.MaxValue(floatArray1);
            //Console.WriteLine(f);

            //string[] stringArray1 = { "951", "789", "635", "600", "300" };
            //UC4_more_than_3_parameter<string> checkString1 = new UC4_more_than_3_parameter<string>(stringArray1);
            //string s = checkString1.MaxValue(stringArray1);
            //Console.WriteLine(s);
            //#endregion UC4_more_than_3_parameters



            //#region UC5
            //int[] intArray = { 577, 668, 555, 29, 926 };
            //UC5<int> checkInt2 = new UC5<int>(intArray);
            //checkInt2.PrintMaxValue();

            //float[] floatArray = { 6.6f, 66.66f, 54.1f, 25.89f, 22.2f };
            //UC5<float> checkFloat2 = new UC5<float>(floatArray);
            //checkFloat2.PrintMaxValue();

            //string[] stringArray = { "65", "269", "257", "22", "559" };
            //UC5<string> checkString2 = new UC5<string>(stringArray);
            //checkString2.PrintMaxValue();
            //#endregion UC5

        }
    }
}
