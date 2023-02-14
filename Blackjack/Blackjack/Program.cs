using System;
using System.Collections.Generic;

namespace ConsoleBlackjack
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                /*
                 
                 Oyunun asıl kodlarını Game methodu içine attım buradaki olay oyun bittikten sonra yeni oyunun başlatıp başlatılmayacağına karar vermek için
                 
                 */
                Console.WriteLine("\r\n█░█░█ █▀█ █ ▀█▀ ▀█▀ █▀▀ █▄░█   █▄▄ █▄█   █░█ ▄▀█ █▀█ █░█ █▀▀ ▄▀█ █▀█ ▀█▀ █▄░█ █░█ █░░ █░░\r\n▀▄▀▄▀ █▀▄ █ ░█░ ░█░ ██▄ █░▀█   █▄█ ░█░   ▀▄▀ █▀█ █▀▄ █▀█ ██▄ █▀█ █▀▄ ░█░ █░▀█ █▄█ █▄▄ █▄▄");
                Game();
                Console.WriteLine("New Game? yes/no");
                string restart = Console.ReadLine();
                if (restart.ToLower() == "no")
                {
                    break; 
                }
            }
        }

        static void Game()
        {


            Random random = new Random();
            int[] deck = new int[52];
            for (int i = 0; i < deck.Length; i++)   
            {
                deck[i] = i % 13 + 1;
            }

            int playerScore = 0;
            int dealerScore = 0;

            int playerCard1 = deck[random.Next(deck.Length)];
            int playerCard2 = deck[random.Next(deck.Length)];
            int dealerCard1 = deck[random.Next(deck.Length)];
            int dealerCard2 = deck[random.Next(deck.Length)];

            playerScore = playerCard1 + playerCard2;
            dealerScore = dealerCard1 + dealerCard2;

            Console.WriteLine("Your cards: " + playerCard1 + ", " + playerCard2);
            Console.WriteLine("Your score: " + playerScore);
            Console.WriteLine();
            Console.WriteLine("Dealer's cards: " + dealerCard1 + ", [hidden]");
            Console.WriteLine();

            while (playerScore < 21)
            {
                Console.WriteLine("Do you want to draw another card? (y/n)");
                string playerChoice = Console.ReadLine();
                if (playerChoice == "y")
                {
                    int newCard = deck[random.Next(deck.Length)];
                    Console.WriteLine("Your new card: " + newCard);
                    playerScore += newCard;
                    Console.WriteLine("Your score: " + playerScore);
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Dealer's cards: " + dealerCard1 + ", " + dealerCard2);
            Console.WriteLine("Dealer's score: " + dealerScore);
            Console.WriteLine();

            while (dealerScore < 17)
            {
                int newCard = deck[random.Next(deck.Length)];
                Console.WriteLine("Dealer's new card: " + newCard);
                dealerScore += newCard;
                Console.WriteLine("Dealer's score: " + dealerScore);
                Console.WriteLine();
            }

            if (playerScore > 21)
            {
                Console.WriteLine("You lose.");
            }
            else if (dealerScore > 21)
            {
                Console.WriteLine("You win!");
            }
            else if (dealerScore > playerScore)
            {
                Console.WriteLine("You lose.");
            }
            else if (dealerScore < playerScore)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("It's a tie.");
            }

            Console.ReadKey();



        }

    }
}