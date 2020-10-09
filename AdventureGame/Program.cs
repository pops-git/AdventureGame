using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    class Program {
        static void Main(string[] args) {
            Console.WindowWidth = 135;
            Art.IntroductionArt2();
            Console.ReadLine();
            //Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = true;
            RunGame();
            Console.ReadLine();
        }
        public static void RunGame() {
            string name = "linus";
            World ng = new World(name);
            do {
                try {
                    //string cmd = Console.ReadLine();
                    //Scroll.ScrollText();
                    Interpreter.Interpret(Console.ReadLine(), ng);
                    //Scroll.ScrollText();
                }
                catch (Exception ex) {
                    Console.WriteLine($"\n{ex.Message}\n");
                }
            } while (!ng.player.CurrentRoom.IsEndPoint);
        }
    }
}
