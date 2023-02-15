using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            int player = 1;
            int choice = 0;
            bool gameOver = false;

            do
            {
                // Draw the game board
                DrawBoard(board);

                // Get player's move
                Console.WriteLine($"Player {player}, enter a number to place your mark:");
                choice = int.Parse(Console.ReadLine());

                // Place the player's mark on the board
                PlaceMark(board, choice, player == 1 ? 'X' : 'O');

                // Check if the game is over
                gameOver = IsGameOver(board);

                // Switch to the other player
                player = player == 1 ? 2 : 1;
            } while (!gameOver);

            // Draw the final game board
            DrawBoard(board);

            // Print the winner or tie message
            int winner = GetWinner(board);
            if (winner == 0)
            {
                Console.WriteLine("The game is a tie!");
            }
            else
            {
                Console.WriteLine($"Player {winner} wins!");
            }

            // Wait for user input before exiting
            Console.WriteLine("Would you like to play again ? yes/no");
            string restart = Console.ReadLine();
           
        }

     



        static void DrawBoard(char[,] board)
        {
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");
            Console.WriteLine("   |   |   ");
        }

        static void PlaceMark(char[,] board, int choice, char mark)
        {
            int row = (choice - 1) / 3;
            int col = (choice - 1) % 3;

            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                Console.WriteLine("Invalid move! Please try again.");
            }
            else
            {
                board[row, col] = mark;
            }
        }

        static bool IsGameOver(char[,] board)
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    return true;
                }
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col])
                {
                    return true;
                }
            }

            // Check diagonals
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true;
            }

            // Check for tie
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] != 'X' && board[row, col] != 'O')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static int GetWinner(char[,] board)
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    if (board[row, 0] == 'X')
                    {
                        return 1;
                    }
                    else if (board[row, 0] == 'O')
                    {
                        return 2;
                    }
                }
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col])
                {
                    if (board[0, col] == 'X')
                    {
                        return 1;
                    }
                    else if (board[0, col] == 'O')
                    {
                        return 2;
                    }
                }
            }

            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == 'X')
                {
                    return 1;
                }
                else if (board[0, 0] == 'O')
                {
                    return 2;
                }
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[0, 2] == 'X')
                {
                    return 1;
                }
                else if (board[0, 2] == 'O')
                {
                    return 2;
                }
            }

            // No winner
            return 0;
        }
    }
}

