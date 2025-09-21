using System;


namespace NumbersGame
{
    internal class Game
    {
        private int firstIntervalNumber;
        private int secondIntervalNumber;
        private int rounds;

        public Game(int first, int second, int rounds)
        {
            this.firstIntervalNumber = first;
            this.secondIntervalNumber = second;
            this.rounds = rounds;

        }

        public void RunGame()
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int randomNumber = random.Next(firstIntervalNumber, secondIntervalNumber);
            int counter = 0;

            for (int i = 0; i < rounds; i++)
            {
                int guessedNumber = GuessingNumber();
                counter++;
                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                else if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }

                if (i == rounds)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }

            }
        }

        public int GuessingNumber()
        {
            int guessingNumber = int.Parse(Console.ReadLine());
            return guessingNumber;
        }
    }


}
