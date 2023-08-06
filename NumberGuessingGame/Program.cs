namespace NumberGuessingGame;

public class Program
{
    static void Main(string[] args)
    {
        var random = new Random();

        var winNumber = random.Next(0, 100);

        var winGuess = false;

        Console.WriteLine("Guess number from 0 to 100!");

        do
        {
            var input = Console.ReadLine();
            if (input == null) continue;
            var userGuess = int.Parse(input);
            
            if (userGuess < winNumber)
            {
                Console.WriteLine("Too low. Try higher!");
            }
            else if (userGuess > winNumber)
            {
                Console.WriteLine("Too high. Try lower!");
            }
            else
            {
                Console.WriteLine("You win!");
                winGuess = true;
            }
            
            Console.WriteLine();
        } while (winGuess == false);
        
    }
}