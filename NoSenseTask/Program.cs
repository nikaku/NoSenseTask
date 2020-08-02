using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace NoSenseTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntts;

            while (true)
            {
                Console.WriteLine("Please, input an array of integers");
                try
                {
                    var userInput = Console.ReadLine(); //"12, 123, 14, 23, 17, 16" 
                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        throw new ArgumentNullException("Initial Array is null");
                    }
                    arrayOfIntts = userInput.Split(",").Select(x => Convert.ToInt32(x)).ToArray();
                    object result1 = arrayOfIntts.ThisDoesntMakeAnySense(x => x > 14 && x < 100, () => 1);
                    object result2 = arrayOfIntts.ThisDoesntMakeAnySense(x => x == 1000, () => 1);

                    Console.WriteLine($"Input : {userInput} - Result1  : {result1}  - Result2  : {result2}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}; Input is not a valid array of integers");
                    continue;
                }
            }


        }
    }
}
