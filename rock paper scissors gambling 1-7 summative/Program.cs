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
                Console.WriteLine("");


                Console.WriteLine("  Rock, Paper, Scissors        Current Balance:" + money);
                Console.WriteLine("----------------------------------------------------------");


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

                //get bet amount
                var var_gamble_amount = Convert.ToInt32(Console.ReadLine());
                int gamble_amount = Convert.ToInt32(var_gamble_amount);

                //betfix
                //if (gamble_amount < 500)
                //{
                //    gamble_amount = 500;
                //}

                if (valid_input == true)
                {
                    var bot_input = generator.Next(3); // bot selects its pick

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

            }

        }

    }
}
