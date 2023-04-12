namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 3);
            Console.WriteLine("Can you guess what my favorite number is?");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == favNumber)
            {
                Console.WriteLine("Nice job!");
            }
           else if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if(userInput > favNumber)
            {
                Console.WriteLine("Too high! Guess again!");
            }
        }
    }
}


