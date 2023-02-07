using System;

namespace SporksFun
{
    class Program
    {
        static void Main(string[] args)
        {
            //create string to hold number input which will later change to int
            string numstr = "";

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            numstr = Console.ReadLine();
            //convert string result to int
            int num = 0;
            Int32.TryParse(numstr, out num);


            // Random number generator
            Random rnd = new Random();


            // roll total array, roll percentages array and stars array
            double[] rollTotals = new double[11];
            double[] rollPct = new double[11];
            string[] stars = new string[11];


            //Simulate roll of dice
            for (int i = 0; i < num; i++)
            {
                //roll first die
                int roll = rnd.Next(0, 6);
                //add total of second die roll
                roll += rnd.Next(0, 6);
                rollTotals[roll]++;
            }

            //convert counts to percentages and assign stars
            for (int i = 0; i < 11; i++)
            {
                rollPct[i] = (rollTotals[i] / num) * 100;
                rollPct[i]= Math.Round(rollPct[i], 0);

                //add stars to stars array for each percentage
                for (int x = 0; x < rollPct[i]; x++)
                {
                    stars[i] += "*";
                }
            }

            // Print results
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls: " + num);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine((i+2) + ":" + stars[i]);
            }
        }
    }
}
