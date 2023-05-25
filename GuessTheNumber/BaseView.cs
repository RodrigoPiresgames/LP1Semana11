using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    public class BaseView : IView
    {
        private readonly Controller controller;

        public UglyView(Controller controller)
        {
            this.controller = controller;
        }

        void StartGame()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        int TakeAGuess()
        {
            Console.Write("Take a guess: ");
            return int.Parse(Console.ReadLine());
        }

        void WrongGuess(int type)
        {
            switch(type)
            {
                case 1:
                    Console.WriteLine("Too low! Try again.");
                case 2:
                    Console.WriteLine("Too high! Try again.");

            }
        }

        void RightGuess(int attempts)
        {
            Console.WriteLine(
            "Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        void VictoryScren()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }

    }
}
