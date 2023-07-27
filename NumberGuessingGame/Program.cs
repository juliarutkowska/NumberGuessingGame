namespace NumberGuessingGame;

public class Program
{
    static void Main(string[] args)
    {
        var r = new Random();

        var winNum = r.Next(0, 100);

        var win = false;

        Console.WriteLine("Guess number from 0 to 100!");

        do
        {
            var s = Console.ReadLine();
            if (s == null) continue;
            var i = int.Parse(s);
            
            if (i < winNum)
            {
                Console.WriteLine("Too low. Try higher!");
            }
            else if (i > winNum)
            {
                Console.WriteLine("Too high. Try lower!");
            }
            else
            {
                Console.WriteLine("You win!");
                win = true;
            }
            
            Console.WriteLine();
        } while (win == false);
        
    }
}