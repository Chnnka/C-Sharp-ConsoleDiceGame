using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ConsoleDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for(int i=0; i<10;i++) {

                Console.WriteLine("Press Enter to roll the Dice");
                Console.ReadKey();
                Console.WriteLine();    

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You Rolled a "+playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if(playerRandomNum>enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wind this round");
                }
                else if(enemyRandomNum>playerRandomNum) 
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");
                }else {
                    Console.WriteLine("Draw..!");
                }
                Console.WriteLine("The Score is Now - Player: "+playerPoints + " - Enemy: "+enemyPoints);
                Console.WriteLine();
            }
            if (playerPoints>enemyPoints)
            {
                Console.WriteLine("Player Wins with: " + playerPoints + " Points");
            }else if(enemyPoints>playerPoints) {
                Console.WriteLine("Enemy Wins with: " + enemyPoints + " Points");

            }
            else
            {
                Console.WriteLine("Game Draw..! "+ "\n" + "Player Points: " + playerPoints + "\n" + "Enemy Points: "+enemyPoints+"\n");
            }
            Console.WriteLine("Please Press Enter for exit game");
            Console.ReadKey();
        }
    }
}
