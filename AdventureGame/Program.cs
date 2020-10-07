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
            Console.Clear();
            RunGame();
            Console.ReadLine();
        }
        public static void RunGame() {
            string name = "linus";
            World ng = new World(name);
            do {
                try {
                    Interpreter.Interpret(Console.ReadLine(), ng);
                }
                catch (Exception ex) {
                    Console.WriteLine($"\n{ex.Message}\n");
                }
            } while (!ng.player.CurrentRoom.IsEndPoint);
        }
    }
}
