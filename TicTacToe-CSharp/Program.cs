namespace TicTacToe_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SetField();
           Console.ReadKey();
        }

        public static void SetField()
        {
            Console.WriteLine("     |     |     ");
            // TODO: REPLACE NUMBERS WITH VARIABLES
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", 1, 2, 3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", 4, 5, 6);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", 7, 8, 9);
            Console.WriteLine("     |     |     ");
        }
    }
}
