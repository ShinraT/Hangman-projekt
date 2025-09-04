using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {

        // *** game state init ***
        int nbrLives = 5;
        string secretWord = "soppa";
        StringBuilder displayWord = new StringBuilder();
       

        for (int i = 0; i < secretWord.Length; i++)
        {
            displayWord.Append("_"); 
        }

        // *** game loop ***
        Console.WriteLine("Game is starting");
        while (nbrLives>0)
        {
            Console.WriteLine(displayWord.ToString()+ ". Nbr Lives"+ nbrLives.ToString());

            // Fetch input
            string? input = Console.ReadLine();
            //Validate input
            if (input == null || input.Length == 0)
            {
                Console.WriteLine("Invalid input. Try again please");
                continue;
            }
                
            char guessedLetter = input[0];

            Console.WriteLine("New guessed: "+ guessedLetter);

            // Check if guessedletter is correct
            bool correct = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (guessedLetter == secretWord[i])
                {
                    correct = true;
                    displayWord[i] = guessedLetter;
                }
            }
            if (correct)
                Console.WriteLine("Correct!");
            else
            {
                Console.WriteLine("False!");
                nbrLives--;
            }
            if (nbrLives < 0)
                break;
            if (secretWord == displayWord.ToString())
                break;
        }


        if (nbrLives <= 0)
            Console.WriteLine("Sorry you've lost!");
        else 
            Console.WriteLine("You won");
        // *** end of game ***


    }
}