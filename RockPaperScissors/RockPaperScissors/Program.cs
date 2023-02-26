using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taş-kağıt-makas oyunu

            Console.WriteLine("\r\n██████████████████████████████████████████████████████████████████████████████████████████████████████████\r\n█─▄▄▄▄█─▄▄─█▄─█─▄█▄─▄▄▀██▀▄─██─▄─▄─█▄─▄▄─█─▄▄▄▄█─█─██▀▄─██▄─█─▄█▄─▄▄▀██▀▄─██▄─▀█▄─▄█▄─▄█▄─█─▄█▄─▄█▄─▀█▀─▄█\r\n█▄▄▄▄─█─██─██─▄▀███─▄─▄██─▀─████─████─▄█▀█▄▄▄▄─█─▄─██─▀─███▄─▄███─▄─▄██─▀─███─█▄▀─███─███▄─▄███─███─█▄█─██\r\n▀▄▄▄▄▄▀▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▀▄▀▄▄▀▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▀▄▄▄▀▀▄▄▄▀▄▄▄▀▄▄▄▀");

            while (true)
            {





                Console.WriteLine("Welcome to Rock-Paper-Scissors!");
                Console.WriteLine("Please enter your choice: ");
                Console.WriteLine("1 - Rock");
                Console.WriteLine("2 - Paper");
                Console.WriteLine("3 - Scissors");

                // Kullanıcının seçimini alın
                int userChoice = Convert.ToInt32(Console.ReadLine());

                // Bilgisayarın rastgele bir seçim yapmasını sağlayın
                Random random = new Random();
                int computerChoice = random.Next(1, 4);

                // Seçimlerin sonuçlarını yazdırın
                Console.WriteLine("You chose: " + GetUserChoice(userChoice));
                Console.WriteLine("The computer chose: " + GetComputerChoice(computerChoice));
                Console.WriteLine("Result: " + DetermineWinner(userChoice, computerChoice));

                Console.ReadLine();
            }
        }




        // Kullanıcının seçimini bir dize olarak döndürür
        static string GetUserChoice(int userChoice)
        {
            if (userChoice == 1)
            {
                return "Rock";
            }
            else if (userChoice == 2)
            {
                return "Paper";
            }
            else if (userChoice == 3)
            {
                return "Scissors";
            }
            else
            {
                return "Invalid choice";
            }
        }

        // Bilgisayarın seçimini bir dize olarak döndürür
        static string GetComputerChoice(int computerChoice)
        {
            if (computerChoice == 1)
            {
                return "Rock";
            }
            else if (computerChoice == 2)
            {
                return "Paper";
            }
            else if (computerChoice == 3)
            {
                return "Scissors";
            }
            else
            {
                return "Invalid choice";
            }
        }

        // Kazananı belirler ve sonucu bir dize olarak döndürür
        static string DetermineWinner(int userChoice, int computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "Tie!";
            }
            else if ((userChoice == 1 && computerChoice == 3) || (userChoice == 2 && computerChoice == 1) || (userChoice == 3 && computerChoice == 2))
            {
                return "You win!";
            }
            else
            {
                return "The computer wins!";
            }
        }
    }
}
