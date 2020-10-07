using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    class Program {
        static void Main(string[] args) {
            Console.WindowWidth = 104;
            Art.IntroductionArt();
            //RunGame();
            Console.ReadLine();
        }
        public static void RunGame() {
            Art.IntroductionArt();
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
