namespace TicTacToe_CSharp
{
    internal class Program
    {
        // the playField matrix - represents the 9 boxes on a TicTacToe board
        static char[,] boardValues =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' },
        };

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
            }
        }
    }
}
