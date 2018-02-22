using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT
{
    class Program
    {
        public static int computersNumber = 0; 
        public static Random num = new Random();
        public static bool gameOver = false;

        static void Main(string[] args)
        {   
            computersNumber = num.Next(0, 101);
            int userNumber = 0;
            Console.WriteLine("Please guess a number between 0 and 100");

            do
            {   
                userNumber = Convert.ToInt32(Console.ReadLine());
                guessNumber(userNumber);
            }

            while (gameOver == false);
        }

        public static void guessNumber(int userNumber) 
        {
            int playAgain = 0; 
            if (userNumber < computersNumber)
                Console.WriteLine("Too low, please try again");
            else if (userNumber > computersNumber)
                Console.WriteLine("Too high, please try again");
            else
            {
                Console.WriteLine("You got it! Press 1 to play again or 2 to play again");
                playAgain = Convert.ToInt32(Console.ReadLine());

                while (playAgain != 1 && playAgain != 2)
                    Console.WriteLine("Please select only 1 or 2");
                playAgain = Convert.ToInt32(Console.ReadLine());
            }
            if (playAgain.Equals(2))
                gameOver = true;
            else
                computersNumber = num.Next(0, 101);

            Console.ReadKey();

        }
        
    }
}
