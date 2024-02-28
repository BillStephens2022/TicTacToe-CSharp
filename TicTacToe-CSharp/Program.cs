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
           SetBoard();
           Console.ReadKey();
        }

        // display the TicTacToe Board

        public static void SetBoard()
        {
            Console.WriteLine("     |     |     ");
            // TODO: REPLACE NUMBERS WITH VARIABLES
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", boardValues[0,0], boardValues[0,1], boardValues[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", boardValues[1, 0], boardValues[1, 1], boardValues[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", boardValues[2, 0], boardValues[2, 1], boardValues[2, 2]);
            Console.WriteLine("     |     |     ");
        }
    }
}
