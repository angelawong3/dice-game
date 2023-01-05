using System;

namespace DiceGame
{
    class Program
    {
        static void Main(String[] args)
        {
            int playerOneRandomNumber;
            int playerTwoRandomNumber;

            int playerOnePoints = 0;
            int playerTwoPoints = 0;

            Random random = new Random();

            // 10 rounds with two players
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice! :)");

                Console.ReadKey();

                playerOneRandomNumber = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerOneRandomNumber);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                playerTwoRandomNumber = random.Next(1, 7);
                Console.WriteLine("Player AI rolled a " + playerTwoRandomNumber);

                if(playerOneRandomNumber > playerTwoRandomNumber)
                {
                    playerOnePoints++;
                    Console.WriteLine("You WIN this round!");
                }
                else if(playerTwoRandomNumber > playerOneRandomNumber)
                {
                    playerTwoPoints++;
                    Console.WriteLine("Player AI WINS this round!");
                }
                else
                {
                    Console.WriteLine("DRAW!");
                }

                Console.WriteLine("Current score - You: " + playerOnePoints + " & " +"Player AI: " + playerTwoPoints + ".");
            }

            if(playerOnePoints > playerTwoPoints)
            {
                Console.WriteLine("You WIN!:)");
            }
            else if(playerTwoPoints> playerOnePoints)
            {
                Console.WriteLine("AI WINS!:)");
            }
            else
            {
                Console.WriteLine("It's a DRAW!:)");
            }

            Console.ReadKey();
        }
    }
}