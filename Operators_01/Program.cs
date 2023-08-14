using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_00
{
    class PersonalData
    {
        static void Main(string[] args)
        {

            //Variables used to show the result.

            string fullName = "Roman Valentinovich Hribov";     //  Name as a string variable
            byte age = 28;                                      //  Age as a byte variable - supposably age wouldn`t be higher than 255.
            string eMail = "r.hribov@afu.ua";                   //  e-mail adress as a string variable
            float devScore = 3f;                                //  Score in programming
            float mathScore = 2f;                               //  Score in mathematics
            float physScore = 5f;                               //  Score in physics
            float scoreSum = devScore + mathScore + physScore;  //  Sum of all scores
            int intDevScore = (int)devScore;                    //  
            int intMathScore = (int)mathScore;                  //  Declaration of variables for int variables to have opportunity to use it as divider for mean. 
            int intPhysScore = (int)physScore;                  //  
            int[] quantityNumber = {intDevScore, intMathScore, intPhysScore};  //Making an array of variables to use in calculation
            int count = quantityNumber.Length;                  //  Function to get the quantity of variables in the array
            float mean = scoreSum / count;                      //  Mean calculation and variable decloration for it.

            string meanFormated = mean.ToString("#.#");         //  String formatting for better looking in the console 

            //Part 1            

            Console.WriteLine($"{"Full Name",-15}: {fullName}");                                    //
            Console.WriteLine($"{"Age",-15}: {age}");                                               //
            Console.WriteLine($"{"Codding score",-15}: {devScore}");                                //
            Console.WriteLine($"{"Math score",-15}: {mathScore}");                                  //  Part 1. Messages in the console from variables. Presonal data.
            Console.WriteLine($"{"Physics score",-15}: {physScore}");                               //
            Console.WriteLine($"{"Contacts",-15}: {eMail}");                                        //
            Console.WriteLine("\nPress Spacebar to see sum, quantity and mean of scores...");       //  End of the part 1. Line to use Spacebar to go to the next part.
            while (Console.ReadKey(true).Key != ConsoleKey.Spacebar) { }                            //
                                                                                //

            //Part 2

            Console.WriteLine($"{"\nSum",-16}: {scoreSum}");        //
            Console.WriteLine($"{"Number",-15}: {count}");          //  Part 2. Messages in the console from calculated variables. Mean, the cuantity of variables and their sum
            Console.WriteLine($"{"Mean:",-15}: {meanFormated}");    //
            Console.ReadKey();
        }

        

    }
}