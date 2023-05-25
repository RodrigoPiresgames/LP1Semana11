using System.Collections.Generic;

namespace GuessTheNumber
{
    public interface IView
    {

        void StartGame();

        int TakeAGuess();

        void WrongGuess(int type);

        void RightGuess(int attempts);

        void VictoryScren();

    }
}