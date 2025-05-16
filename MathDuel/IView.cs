using System.Collections.Generic;

namespace MathDuel
{
    public interface IView
    {
        void StartGame();

        int TakeAGuess(string questionToAsk);

        void WrongGuess(int answer);

        void RightGuess();

        void LoseScreen(int totalPoints);
    }
}