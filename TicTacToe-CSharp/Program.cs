namespace TicTacToe_CSharp
{
    internal class Program

    {
        // the playField matrix - represents the 9 boxes on a TicTacToe board
        static char[,] initialBoardValues =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' },
        };

        static char[,] boardValues =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' },
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int playerNumber = 2; // player 1 starts
            int userInput = 0;
            bool isValidInput = true;

           SetBoard();
          

            do
            {
                
                if (playerNumber == 2)
                {
                    playerNumber = 1;
                    EnterXorO(playerNumber, userInput);
                }
                else if (playerNumber == 1)
                {
                    playerNumber = 2;
                    EnterXorO(playerNumber, userInput);
                }

                SetBoard();

                #region
                // Check winning conditions
                char[] playerChars = { 'X', 'O' };
                foreach (char playerChar in playerChars)
                {
                    if (((boardValues[0,0] == playerChar) && (boardValues[0,1] == playerChar) & (boardValues[0,2] == playerChar)) // checks 1st row
                        || ((boardValues[1, 0] == playerChar) && (boardValues[1, 1] == playerChar) & (boardValues[1, 2] == playerChar))// checks 2nd row
                        || ((boardValues[2, 0] == playerChar) && (boardValues[2, 1] == playerChar) & (boardValues[2, 2] == playerChar))// checks 3rd row
                        || ((boardValues[0, 0] == playerChar) && (boardValues[1, 0] == playerChar) & (boardValues[2, 0] == playerChar)) // checks 1st column
                        || ((boardValues[0, 1] == playerChar) && (boardValues[1, 1] == playerChar) & (boardValues[2, 1] == playerChar)) // checks 2nd column
                        || ((boardValues[0, 2] == playerChar) && (boardValues[1, 2] == playerChar) & (boardValues[2, 2] == playerChar)) // checks 3rd column
                        || ((boardValues[0, 0] == playerChar) && (boardValues[1, 1] == playerChar) & (boardValues[2, 2] == playerChar)) // checks left to right diag
                        || ((boardValues[0, 2] == playerChar) && (boardValues[1, 1] == playerChar) & (boardValues[2, 0] == playerChar))  // checks right to left diag
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won!");

                        }
                        Console.WriteLine("Please press any key to reset game...");
                        Console.ReadKey();
                        
                        ResetBoard();

                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("We have a Draw!!");
                        Console.WriteLine("Please press any key to reset game...");
                        Console.ReadKey();
                        ResetBoard();
                        break;
                    }
                }
                #endregion

                #region
                // Test if field has already been selected
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field by number: ", playerNumber);
                    try
                    {
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((userInput == 1) && (boardValues[0, 0] == '1'))
                    {
                        isValidInput = true;
                    }
                    else if ((userInput == 2) && (boardValues[0, 1] == '2'))
                    {
                        isValidInput = true;
                    }
                    else if ((userInput == 3) && (boardValues[0, 2] == '3'))
                    {
                        isValidInput = true;
                    }
                    else if ((userInput == 4) && (boardValues[1, 0] == '4'))
                    {
                        isValidInput = true;
                    }
                    else if ((userInput == 5) && (boardValues[1, 1] == '5'))
                    {
                        isValidInput = true;
                    }
                    else if ((userInput == 6) && (boardValues[1, 2] == '6'))
                    {
                        isValidInput = true;
                    }
                    else if ((userInput == 7) && (boardValues[2, 0] == '7'))
                    {
                        isValidInput = true;
                    }
                    else if ((userInput == 8) && (boardValues[2, 1] == '8'))
                    {
                        isValidInput = true;
                    }
                    else if ((userInput == 9) && (boardValues[2, 2] == '9'))
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        isValidInput = false;   
                        Console.WriteLine("Incorrect Input, please choose another field!");
                    }
                   


                } while (!isValidInput);

                #endregion

            } while (true);
        }

        // reset fields to inital values
        public static void ResetBoard()
        {
            boardValues = initialBoardValues;
            SetBoard();
            turns = 0;
        }

        // display the TicTacToe Board based on the boardValues

        public static void SetBoard()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", boardValues[0,0], boardValues[0,1], boardValues[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", boardValues[1, 0], boardValues[1, 1], boardValues[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", boardValues[2, 0], boardValues[2, 1], boardValues[2, 2]);
            Console.WriteLine("     |     |     ");
            turns++;
        }

        public static void EnterXorO(int playerNumber, int userInput)
        {
            char playerChar = ' ';
            if (playerNumber == 1) 
            {
                playerChar = 'X';
            } else if (playerNumber == 2)
            {
                playerChar = 'O';
            }
           
            switch(userInput) 
            {
                case 1: boardValues[0, 0] = playerChar; break; // note using "char" type for populating the board                      
                case 2: boardValues[0, 1] = playerChar; break;
                case 3: boardValues[0, 2] = playerChar; break;
                case 4: boardValues[1, 0] = playerChar; break;
                case 5: boardValues[1, 1] = playerChar; break;
                case 6: boardValues[1, 2] = playerChar; break;
                case 7: boardValues[2, 0] = playerChar; break;
                case 8: boardValues[2, 1] = playerChar; break;
                case 9: boardValues[2, 2] = playerChar; break;
            }
        }
    }
}
