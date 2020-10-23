using System;

namespace AdventureGame {
    class Program {
        /* To-Do list:
         * lösa grafik per tid istället för loopar.
         * problematik: windows sleep granularity är ish 16ms.
         * detta gör en lösning med sleep omöjlig då 16 ms är för lång tid i detta fall.
         * lösning: räkna milliseconds med hjälp av datetime.
         * 
         * inte jämföra fritext, bara variabler/konstanter
         * 
         * tänka på vem jag skriver koden för (relaterar till struktur och namnsättning)
         */
        static void Main(string[] args) {
            RunGame();
            Console.ReadLine();
        }
        public static void RunGame() {
            RunIntroduction();
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
        public static void RunIntroduction() {
            Art.IntroductionArt2();
            Console.ReadLine();
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = true;
        }
    }
}
