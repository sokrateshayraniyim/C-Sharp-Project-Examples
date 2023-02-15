# This is a Tic-Tac-Toe game implemented in C#.
The program uses a 2D char array to represent the game board and prompts the players to take turns placing their marks (X or O) on the board. The game ends when a player wins or there is a tie.

## The Main function initializes the game board, player number, and choice variables.
 Then, it enters a loop that continues until the game is over. In each iteration of the loop, the game board is drawn, the current player is prompted for their move, the move is placed on the board, and the program checks if the game is over. If the game is over, the loop ends and the final game board is drawn, and the winner or tie message is printed.

## The DrawBoard function is used to draw the game board to the console.

## The PlaceMark function is used to place a player's mark on the board. It takes the board, the player's choice, and the mark as parameters, and it calculates the corresponding row and column indices for the choice. If the selected cell is already occupied, the function displays an error message.

## The IsGameOver function checks if the game is over by checking if any player has won or if there is a tie. It checks for winning rows, columns, and diagonals, and it also checks for ties by iterating over every cell on the board and returning false if any cell is empty.

## The GetWinner function returns the number of the winning player or 0 if there is no winner. It checks for winning rows, columns, and diagonals and returns the number of the player whose mark is on the winning line.




## Requirements

To run this application, you will need to have the following installed on your computer:

- [.NET Core SDK](https://dotnet.microsoft.com/download)

## Installation

1. Clone the repository or download the source code as a zip file.
2. Extract as folder.
3. Go to ```TicTacToe\TicTacToe\bin\Debug\net6.0 ``` and run TicTacToe.exe

## Contributing
If you would like to contribute to this project, please fork the repository and submit a pull request.
## License
This project is licensed under the [MIT License](https://opensource.org/license/mit-0/).
