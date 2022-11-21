namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string name = "Demitri";

            int a = 117;

            char Spotify = 'S';

            bool x = true;

            double longpi = 3.14159265358979D;

            decimal lifeofpi = 3.14m;


            Console.WriteLine($"My name is {name}, I feel {a} years old.");
            Console.WriteLine($"I listen to music on spotify, but it should be a capital {Spotify}.");
            Console.WriteLine($"This is {x}.");
            Console.WriteLine($"A lot of digits for Pi are {longpi}.");
            Console.WriteLine($"It is usually abbreviated to {lifeofpi}.");

            Console.WriteLine("or");

            Console.WriteLine($"My name is {name}, I feel {a} years old. I listen to music on spotify, but it should be a capital {Spotify}. This is {x}. A lot of digits for Pi are {longpi}. It is usually abbreviated to {lifeofpi}."
                );


        }
    }
}
