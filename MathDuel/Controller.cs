using System;

namespace MathDuel
{
    public class Controller
    {

        private IView view;

        private bool guessedCorrectly;
        private int attempts;
        private int targetNumber;

        public Controller()
        {
            Random random = new Random();

            this.targetNumber = random.Next(1, 101);
            this.attempts = 0;
            this.guessedCorrectly = false;

        }

        public void Run(IView view)
        {
            int guess;
            this.view = view;

            view.StartGame();

            do
            {
                guess = view.TakeAGuess();

                attempts++;

                if (guess == targetNumber)
                {
                    view.RightGuess(attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {
                    view.WrongGuess(1);
                }
                else
                {
                    view.WrongGuess(2);
                }
            }
            while (guessedCorrectly != true);

            view.VictoryScren();
        }

    }

}