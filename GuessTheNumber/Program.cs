using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Controller controller = new Controller();

            // Create view
            IView view = new BaseView(controller);

            // Start program
            controller.Run(view);
        }
    }
}