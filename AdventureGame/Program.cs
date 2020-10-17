using System;

namespace AdventureGame {
    class Program {
        static void Main(string[] args) {
            RunGame();
            Console.ReadLine();
        }
        public static void RunGame() {
            Art.IntroductionArt2();
            Console.ReadLine();
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = true;
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
