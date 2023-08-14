using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_00
{
    class PersonalData
    {

        //Variables used to show the result.

        static void Main(string[] args)
        {
            string fullName = "Roman Valentinovich Hribov";                 //  Name as a string variable
            byte age = 28;                                                  //  Age as a byte variable - supposably age wouldn`t be higher than 255.
            string eMail = "r.hribov@afu.ua";                               //  e-mail adress as a string variable
            float devScore = 3f;                                            //  Score in programming
            float mathScore = 2f;                                           //  Score in mathematics
            float physScore = 5f;                                           //  Score in physics
            float[] scoreSum = { devScore, mathScore, physScore };          //  Making an array of variables to use in calculation
            float mean = CalculateMean(scoreSum);                           //  Function to get the mean of variables in the array
            string meanFormated = mean.ToString("#.#");                     //  String format for mean value

            //Part 1 

            Console.WriteLine($"{"Full Name",-15}: {fullName}");                                    //  
            Console.WriteLine($"{"Age",-15}: {age}");                                               //
            Console.WriteLine($"{"Codding score",-15}: {devScore}");                                //  Part 1. Messages in the console from variables. Presonal data.
            Console.WriteLine($"{"Math score",-15}: {mathScore}");                                  //
            Console.WriteLine($"{"Physics score",-15}: {physScore}");                               //
            Console.WriteLine($"{"Contacts",-15}: {eMail}");                                        //
            Console.WriteLine("\nPress Spacebar to see mean of scores...");                         //  End of the part 1. Line to use Spacebar to go to the next part.
            while (Console.ReadKey(true).Key != ConsoleKey.Spacebar) { }                            //           

            //Part 1 

            Console.WriteLine($"{"Mean:", -15}: {meanFormated}");                                   //  Part 2. Mean value of the variables.
            Console.ReadKey();                                                                      //
        }

        private static float CalculateMean(float[] scoreSum)                     //  Method to calculate the mean value with CalculateMean 
        {                   
            float sum = 0;
            foreach (float valueTemp in scoreSum)                                //  "foreach" loop to iterate through each element in the array
            {
                sum += valueTemp;                                                //  The way of counting the quantity of variables in the array.
            }
            float mean = sum / scoreSum.Length;                                  //  Mean calculation.
            return mean;                                                         //  Returning the value to the variable to show it in the meanFormated string in the upper part of code.


        }
       
    }
}