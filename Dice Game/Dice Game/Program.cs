class DiceRoll
{
    static void Main(string[] args)
    {
        int dice1 = 0;
        int dice2 = 0;
        int playerScore = 0;
        int AiScore = 0;
        int currectRound = 0;
        Random rnd = new Random();

        void PlayerTurn()
        {
            Console.WriteLine("Press any key");
            Console.ReadKey();
            dice1 = rnd.Next(1,7);
            playerScore = dice1 + playerScore;
            Console.WriteLine("You got a " + dice1);
        }
        void AiTurn()
        {
            Console.WriteLine("Ai Turn");
            dice2 = rnd.Next(1, 7);
            AiScore = dice2 + AiScore;
            Thread.Sleep(300);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("Ai got a " + dice2);
        }

        while(currectRound < 10)
        {
            PlayerTurn();
            AiTurn();

            if(dice1 < dice2)
            {
                Console.WriteLine("Ai won this round");
            }
            else
            {
                Console.WriteLine("You won this round");
            }
            currectRound++;
        }

        if(playerScore < AiScore) 
        {
            Console.WriteLine("Ai Won");
        }
        else 
        {
            Console.WriteLine("You Won");
        }

        Console.WriteLine("Player Score: " + playerScore);
        Console.WriteLine("Ai Score: " + AiScore);

    }
}
