using System.Data.SqlTypes;
using System.Diagnostics;

namespace rock_paper_scissors_gambling_1_7_summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine(@"Welcome to Rock, Paper, Scissors Casino
");
            List<string> rps_list = new List<string> { "rock", "paper", "scissors" };

            var debug = false;
            int money = 2000;

            while (money > -500)
            {
                Console.Clear();


                Console.WriteLine("  Rock, Paper, Scissors        Current Balance:" + money);
                Console.WriteLine("----------------------------------------------------------");

                //get bet amount
                //var gamble_amount = Convert.ToInt32(Console.ReadLine());
                int gamble_amount;
                Console.WriteLine();
                Console.WriteLine("place your bet");
                Int32.TryParse(Console.ReadLine(), out gamble_amount);
                //Console.WriteLine(gamble_amount);

                //betfix
                if (gamble_amount < 100)
                {
                    gamble_amount = 100;
                }
                Console.WriteLine("Current wager: " + gamble_amount);
                Console.WriteLine();


                //get user input
                Console.WriteLine("Rock, Paper, or Scissors!");
                var var_user_input = Console.ReadLine().ToLower();
                int int_user_input = -1;
                var valid_input = false;
                for (int i = 0; i <= 2; i = i + 1)
                {
                    if (var_user_input == rps_list[i])
                    {
                        int_user_input = i;
                        valid_input = true;
                    }

                }


                if (valid_input == true)
                {
                    var bot_input = generator.Next(3); //bot selects its pick

                    //rock paper scissors main game loop
                    if (debug)
                    {
                        Console.WriteLine("you picked " + rps_list[int_user_input] + "  " + int_user_input);
                        Console.WriteLine("they picked " + rps_list[bot_input] + "  " + bot_input);
                        Console.WriteLine();
                    }
                    if (int_user_input == bot_input)
                    {
                        Console.WriteLine("they picked " + rps_list[bot_input] + " you tied..");
                    }
                    else if (int_user_input == bot_input + 1 || int_user_input == bot_input - 2)
                    {
                        Console.WriteLine("they picked " + rps_list[bot_input] + " you WIN!");
                        money = money + gamble_amount;
                    }
                    else
                    {
                        Console.WriteLine("they picked " + rps_list[bot_input] + " you LOSE..!?");
                        money = money - gamble_amount;
                    }

                }
                else
                {
                    Console.WriteLine("invalid input");
                }

                Console.WriteLine("press anywhere to continue");
                Console.ReadLine();

            }
            Console.Clear();
            Console.WriteLine(@"
After months on the run, you thought you were free. You changed your name, fled the country, even 
learned to live off the grid. But the IRS never forgets. They don’t forgive. And they always collect.

Just when you let your guard down—BAM!—they descend like financial assassins in their black suits, 
calculators holstered, W-2s at the ready. “You thought you could outrun interest?” one sneers as they 
slap the cuffs on. “Penalties compound, my friend.”

Your fate? A cold, dimly lit audit room where every deduction is scrutinized, every expense questioned. 
There’s no escape now. The IRS has you… and they always get their money.");
            Console.ReadLine();

        }

    }
}
