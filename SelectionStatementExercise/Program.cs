namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber = random.Next(1, 11);
            int response = 0;


            while (response != favNumber)
            {
                Console.WriteLine("Give me a number between 1 and 10:");
                response = int.Parse(Console.ReadLine());

                if (response < favNumber)
                {
                    Console.WriteLine($"Too low!\nYour guess: {response}");
                }
                else if (response > favNumber)
                {
                    Console.WriteLine($"Too high!\nYour guess: {response}");
                }
                else
                {
                    Console.WriteLine($"You guessed it!\nThe favorite number was {favNumber}!");
                }
            }

            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("what is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I don't prefer math");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "p.e.":
                    Console.WriteLine("P.E. is fun!");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite too");
                    break;
                case "geography":
                    Console.WriteLine("I like to study the world too");
                    break;
                default:
                    Console.WriteLine("I like that too");
                    break;
            }
        }
        
    }
}


                
                
            
            

         