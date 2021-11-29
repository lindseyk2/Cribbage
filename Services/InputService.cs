using System;
using Raylib_cs;

using Final_Project.Casting;

namespace Final_Project.Services
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        public InputService()
        {

        }

        public bool ISMouseClick()
        {
            return Raylib.IsMouseButtonPressed(Raylib_cs.MouseButton.MOUSE_LEFT_BUTTON);
        }

        public Point GetMouseClick()
        {
            int x = Raylib.GetMouseX();
            int y = Raylib.GetMouseY();

            return new Point(x, y);
        }

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }
}