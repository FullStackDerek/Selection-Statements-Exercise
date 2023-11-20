namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 11;

            //var r = new Random();
            //var favNumber = r.Next(1, 1000);

            Console.WriteLine("Guess my favorite number: ");
            int userInput = int.Parse(Console.ReadLine());

            if(userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Perfect!");
            }
        }
    }
}
