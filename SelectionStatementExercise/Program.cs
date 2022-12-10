namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 77;

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }

            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }

            else
            {
                Console.WriteLine("You Guessed It!");
            }
            
        }
    }
}
