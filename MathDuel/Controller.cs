using System;
using System.Runtime.CompilerServices;

namespace MathDuel
{
    public class Controller
    {

        private IView view;
        private Model model;
        private int score = 0;
        private int wrongAnswers = 0;

        public Controller(Model model)
        {
            this.model = model;
        }

        public void Run(IView view)
        {
            this.view = view;

            view.StartGame();

            Random rand = new Random();

            do
            {
                int a = rand.Next(1, 11);     // 1 to 10
                int b = rand.Next(1, 11);
                int operation = rand.Next(3); // 0: +, 1: -, 2: *

                int correctAnswer;
                string question;

                if (operation == 0)
                {
                    correctAnswer = a + b;
                    question = $"{a} + {b} = ?";
                }
                else if (operation == 1)
                {
                    correctAnswer = a - b;
                    question = $"{a} - {b} = ?";
                }
                else
                {
                    correctAnswer = a * b;
                    question = $"{a} * {b} = ?";
                }

                
                string input = view.TakeAGuess(question);

                int playerAnswer = int.Parse(input);

                if (playerAnswer == correctAnswer)
                {
                    view.RightGuess();
                    score++;
                }
                else
                {
                    view.WrongGuess(correctAnswer);
                    wrongAnswers++;
                }
            }
            while (wrongAnswers < 3);

            view.LoseScreen(score);
        }

    }

}