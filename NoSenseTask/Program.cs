using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace NoSenseTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntts;
            object result1;
            object result2;
            string userInput = string.Empty;

            while (true)
            {
                Console.WriteLine("Please, input an array of integers");
                try
                {
                    userInput = Console.ReadLine(); //"12, 123, 14, 23, 17, 16" 
                    arrayOfIntts = userInput.Split(",").Select(x => Convert.ToInt32(x)).ToArray();
                    if (arrayOfIntts == null)
                    {
                        throw new ArgumentNullException("Initial Array is null");
                    }
                    result1 = arrayOfIntts.ThisDoesntMakeAnySense(x => true , () => RandomNumberGenerator.GetInt32(1, 100));
                    result2 = arrayOfIntts.ThisDoesntMakeAnySense(x => false, () => RandomNumberGenerator.GetInt32(1, 100));

                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}; Input is not a valid array of integers");
                    continue;
                }
                Console.WriteLine($"Input : {userInput} {Environment.NewLine} Result1 : {result1} {Environment.NewLine} Result2  : {result2} ");

            }


        }
    }
}
