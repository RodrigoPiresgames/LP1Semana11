using System;
using System.Collections.Generic;

namespace MathDuel
{
    public class ConsoleView : IView
    {
        private readonly Controller controller;
        private readonly Model model;

        public ConsoleView(Controller controller, Model model)
        {
            this.controller = controller;
            this.model = model;
        }

        public void StartGame()
        {
            Console.WriteLine("=== Math Duel ===");
            Console.WriteLine("Answer the math problems correctly!");
            Console.WriteLine("You can make up to 3 mistakes.");
            Console.WriteLine();
        }

        public string TakeAGuess(string questionToAsk)
        {
            Console.Write("Question: " + questionToAsk + " ");
            return Console.ReadLine();
        }

        public void WrongGuess(int answer)
        {
            Console.WriteLine($"Wrong! The correct answer was {answer}.\n");
        }

        public void RightGuess()
        {
            Console.WriteLine("Correct!\n");
        }

        public void LoseScreen(int totalPoints)
        {
            Console.WriteLine($"Game over! Your final score is: {totalPoints}");
        }

    }
}