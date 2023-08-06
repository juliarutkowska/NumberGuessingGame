namespace NumberGuessingGame;

public class NumberGuessingGame
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

            var guessMessage = userGuess switch
            {
                _ when userGuess < winNumber => "Too low. Try higher!",
                _ when userGuess > winNumber => "Too high. Try lower!",
                _ when userGuess == winNumber => "You win!",
                _ => ""
            };

            Console.WriteLine(guessMessage);

            if (userGuess == winNumber)
            {
                winGuess = true;
            }
            
            Console.WriteLine();
        } while (winGuess == false);
        
    }
}