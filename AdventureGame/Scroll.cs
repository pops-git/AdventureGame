using System;

namespace AdventureGame {
    public static class Scroll {
        //work in progress, trying to solve how to get the text to scroll as you play.
        public static void ScrollText() {
            Console.MoveBufferArea(0, 10, Console.BufferWidth, 6, 0, 9);
            Console.SetCursorPosition(0, 9);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, 15);
        }
    }
}
