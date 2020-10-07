using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public static class Art {
        public static void IntroductionArt1() {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.CursorVisible = false;
         Console.WriteLine(@"  o  8               8                            o              8   8                                  ");
         Console.WriteLine(@"  8  8               8                            8              8   8                                  ");
            TypeAnimationL(@" o8P 8oPYo. .oPYo.   8oPYo. .oPYo. o    o odYo.  o8P .oPYo. .oPYo8   8oPYo. .oPYo. o    o .oPYo. .oPYo. ");
            TypeAnimationR(@"  8  8    8 8oooo8   8    8 .oooo8 8    8 8' `8   8  8oooo8 8    8   8    8 8    8 8    8 Yb..   8oooo8 ");
            TypeAnimationL(@"  8  8    8 8.       8    8 8    8 8    8 8   8   8  8.     8    8   8    8 8    8 8    8   'Yb. 8.     ");
            TypeAnimationR(@"  8  8    8 `Yooo'   8    8 `YooP8 `YooP' 8   8   8  `Yooo' `YooP'   8    8 `YooP' `YooP' `YooP' `Yooo' ");
            TypeAnimationL(@"::..:..:::..:.....:::..:::..:.....::.....:..::..::..::.....::.....:::..:::..:.....::.....::.....::.....:");
            TypeAnimationR(@"::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            TypeAnimationL(@"::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");
            AnimateRandom("                                 Copyright © 2020 by Linus Krönström");
            Console.WriteLine("\n");
        Console.WriteLine("                                      Press any key to continue");

        }
        public static void IntroductionArtColorSwap() {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            
        }
        public static void IntroductionArt2() {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.CursorVisible = false;
                TypeAnimationL(@"▄▄▄█████▓ ██░ ██ ▓█████     ██░ ██  ▄▄▄       █    ██  ███▄    █ ▄▄▄█████▓▓█████ ▓█████▄     ██░ ██  ▒█████   █    ██   ██████ ▓█████ ");
                TypeAnimationR(@"▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓██░ ██▒▒████▄     ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▒██▀ ██▌   ▓██░ ██▒▒██▒  ██▒ ██  ▓██▒▒██    ▒ ▓█   ▀ ");
                TypeAnimationL(@"▒ ▓██░ ▒░▒██▀▀██░▒███      ▒██▀▀██░▒██  ▀█▄  ▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ░██   █▌   ▒██▀▀██░▒██░  ██▒▓██  ▒██░░ ▓██▄   ▒███   ");
                TypeAnimationR(@"░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ░▓█ ░██ ░██▄▄▄▄██ ▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ░▓█▄   ▌   ░▓█ ░██ ▒██   ██░▓▓█  ░██░  ▒   ██▒▒▓█  ▄ ");
                TypeAnimationL(@"  ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▓█▒░██▓ ▓█   ▓██▒▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░▒████▓    ░▓█▒░██▓░ ████▓▒░▒▒█████▓ ▒██████▒▒░▒████▒");
                TypeAnimationR(@"  ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░    ▒ ░░▒░▒ ▒▒   ▓▒█░░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░ ▒▒▓  ▒     ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ▒ ▒▓▒ ▒ ░░░ ▒░ ░");
                TypeAnimationL(@"    ░     ▒ ░▒░ ░ ░ ░  ░    ▒ ░▒░ ░  ▒   ▒▒ ░░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░ ░ ▒  ▒     ▒ ░▒░ ░  ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░▒  ░ ░ ░ ░  ░");
                TypeAnimationR(@"  ░       ░  ░░ ░   ░       ░  ░░ ░  ░   ▒    ░░░ ░ ░    ░   ░ ░   ░         ░    ░ ░  ░     ░  ░░ ░░ ░ ░ ▒   ░░░ ░ ░ ░  ░  ░     ░   ");
             Console.WriteLine(@"          ░  ░  ░   ░  ░    ░  ░  ░      ░  ░   ░              ░             ░  ░   ░        ░  ░  ░    ░ ░     ░           ░     ░  ░");
             Console.WriteLine(@"                                                                                  ░                                                   ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");
                  AnimateRandom("                                               Copyright © 2020 by Linus Krönström");
            Console.WriteLine("\n");
              Console.WriteLine("                                                    Press any key to continue");
             
        }
        public static void TypeAnimationL(string str) {
            
            for (int i = 0; i < str.Length; i++) {
                Console.Write(str[i]);
                for (int j = 0; j < 3000000; j++) ;
            }
            //Console.WriteLine();
        }
        public static void TypeAnimationR(string str) {
            for (int i = str.Length - 1; i >= 0; --i) {
                Console.SetCursorPosition(i, Console.CursorTop);
                Console.Write(str[i]);
                for (int j = 0; j < 3000000; ++j) ;
            }
            Console.WriteLine();
        }
        public static void AnimateRandom(string str) {
            List<int> indices = Enumerable.Range(0, str.Length).ToList();
            Random rng = new Random();

            for (int i = 0; i < str.Length; ++i) {
                int j = rng.Next(indices.Count);
                int index = indices[j];
                indices.RemoveAt(j);
                Console.SetCursorPosition(index, Console.CursorTop);
                Console.Write(str[index]);
                for (int k = 0; k < 22000000; ++k) ;
            }
        }
    }
}
