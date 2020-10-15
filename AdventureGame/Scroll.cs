using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public static class Scroll {
        //work in progress, trying to get the text to scroll as you play.
        public static void ScrollText() {
            Console.MoveBufferArea(0, 10, Console.BufferWidth, 6, 0, 9);
            Console.SetCursorPosition(0, 9);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, 15);
        }
    }
}
