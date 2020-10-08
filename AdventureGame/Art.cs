using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public static class Art {
        public static void IntroductionArt1() {
            Console.WriteLine("\n\n");
            Console.WriteLine(@"▄▄▄█████▓ ██░ ██ ▓█████     ██░ ██  ▄▄▄       █    ██  ███▄    █ ▄▄▄█████▓▓█████ ▓█████▄     ██░ ██  ▒█████   █    ██   ██████ ▓█████ ");
            Console.WriteLine(@"▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓██░ ██▒▒████▄     ██  ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓█   ▀ ▒██▀ ██▌   ▓██░ ██▒▒██▒  ██▒ ██  ▓██▒▒██    ▒ ▓█   ▀ ");
            Console.WriteLine(@"▒ ▓██░ ▒░▒██▀▀██░▒███      ▒██▀▀██░▒██  ▀█▄  ▓██  ▒██░▓██  ▀█ ██▒▒ ▓██░ ▒░▒███   ░██   █▌   ▒██▀▀██░▒██░  ██▒▓██  ▒██░░ ▓██▄   ▒███   ");
            Console.WriteLine(@"░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ░▓█ ░██ ░██▄▄▄▄██ ▓▓█  ░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒▓█  ▄ ░▓█▄   ▌   ░▓█ ░██ ▒██   ██░▓▓█  ░██░  ▒   ██▒▒▓█  ▄ ");
            Console.WriteLine(@"  ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▓█▒░██▓ ▓█   ▓██▒▒▒█████▓ ▒██░   ▓██░  ▒██▒ ░ ░▒████▒░▒████▓    ░▓█▒░██▓░ ████▓▒░▒▒█████▓ ▒██████▒▒░▒████▒");
            Console.WriteLine(@"  ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░    ▒ ░░▒░▒ ▒▒   ▓▒█░░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒   ▒ ░░   ░░ ▒░ ░ ▒▒▓  ▒     ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ▒ ▒▓▒ ▒ ░░░ ▒░ ░");
            Console.WriteLine(@"    ░     ▒ ░▒░ ░ ░ ░  ░    ▒ ░▒░ ░  ▒   ▒▒ ░░░▒░ ░ ░ ░ ░░   ░ ▒░    ░     ░ ░  ░ ░ ▒  ▒     ▒ ░▒░ ░  ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░▒  ░ ░ ░ ░  ░");
            Console.WriteLine(@"  ░       ░  ░░ ░   ░       ░  ░░ ░  ░   ▒    ░░░ ░ ░    ░   ░ ░   ░         ░    ░ ░  ░     ░  ░░ ░░ ░ ░ ▒   ░░░ ░ ░ ░  ░  ░     ░   ");
            Console.WriteLine(@"          ░  ░  ░   ░  ░    ░  ░  ░      ░  ░   ░              ░             ░  ░   ░        ░  ░  ░    ░ ░     ░           ░     ░  ░");
            Console.WriteLine(@"                                                                                  ░                                                   ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");
            Console.WriteLine("                                                Copyright © 2020 by Linus Krönström");
            Console.WriteLine("\n");
            Console.WriteLine("                                                     Press any key to continue");

        }
        public static void IntroductionArtColorSwap() {
            while (true) {
                for (int i = 1; i < 15; ++i) {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = (ConsoleColor)i;
                    IntroductionArt1();
                    for (int j = 0; j < 70000; j++) {
                        if (Console.KeyAvailable) {
                            return;
                        }
                    }
                }
            }
        }
        public static void IntroductionArt2() {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.CursorVisible = false;
            Console.WriteLine("\n\n");
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
                  AnimateRandom("                                                Copyright © 2020 by Linus Krönström");
            Console.WriteLine("\n");
              Console.WriteLine("                                                     Press any key to continue");
            IntroductionArtColorSwap();
        }
        public static void LivingroomArt() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            TypeAnimationL(@"                        (`-.                .-') _            _  .-')                            _   .-')    ");
            TypeAnimationR(@"                      _(OO  )_             ( OO ) )          ( \( -O )                          ( '.( OO )_  ");
            TypeAnimationL(@" ,--.      ,-.-') ,--(_/   ,. \ ,-.-') ,--./ ,--,'  ,----.    ,------.  .-'),-----.  .-'),-----. ,--.   ,--.)");
            TypeAnimationR(@" |  |.-')  |  |OO)\   \   /(__/ |  |OO)|   \ |  |\ '  .-./-') |   /`. '( OO'  .-.  '( OO'  .-.  '|   `.'   | ");
            TypeAnimationL(@" |  | OO ) |  |  \ \   \ /   /  |  |  \|    \|  | )|  |_( O- )|  /  | |/   |  | |  |/   |  | |  ||         | ");
            TypeAnimationR(@" |  |`-' | |  |(_/  \   '   /,  |  |(_/|  .     |/ |  | .--, \|  |_.' |\_) |  |\|  |\_) |  |\|  ||  |'.'|  | ");
            TypeAnimationL(@"(|  '---.',|  |_.'   \     /__),|  |_.'|  |\    | (|  | '. (_/|  .  '.'  \ |  | |  |  \ |  | |  ||  |   |  | ");
            TypeAnimationR(@" |      |(_|  |       \   /   (_|  |   |  | \   |  |  '--'  | |  |\  \    `'  '-'  '   `'  '-'  '|  |   |  | ");
            TypeAnimationL(@" `------'  `--'        `-'      `--'   `--'  `--'   `------'  `--' '--'     `-----'      `-----' `--'   `--' ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void KitchenArt() {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    TypeAnimationL(@".-. .-')           .-') _             ('-. .-.   ('-.       .-') _  ");
                    TypeAnimationR(@"\  ( OO )         (  OO) )           ( OO )  / _(  OO)     ( OO ) ) ");
                    TypeAnimationL(@",--. ,--.  ,-.-') /     '._  .-----. ,--. ,--.(,------.,--./ ,--,'  ");
                    TypeAnimationR(@"|  .'   /  |  |OO)|'--...__)'  .--./ |  | |  | |  .---'|   \ |  |\  ");
                    TypeAnimationL(@"|      /,  |  |  \'--.  .--'|  |('-. |   .|  | |  |    |    \|  | ) ");
                    TypeAnimationR(@"|     ' _) |  |(_/   |  |  /_) |OO  )|       |(|  '--. |  .     |/  ");
                    TypeAnimationL(@"|  .   \  ,|  |_.'   |  |  ||  |`-'| |  .-.  | |  .--' |  |\    |   ");
                    TypeAnimationR(@"|  |\   \(_|  |      |  | (_'  '--'\ |  | |  | |  `---.|  | \   |   ");
                    TypeAnimationL(@"`--' '--'  `--'      `--'    `-----' `--' `--' `------'`--'  `--'   ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void EndOfDemoArt() {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                TypeAnimationL(@"   ('-.       .-') _  _ .-') _                                       _ .-') _     ('-.  _   .-')                ");
                TypeAnimationR(@" _(  OO)     ( OO ) )( (  OO) )                                     ( (  OO) )  _(  OO)( '.( OO )_              ");
                TypeAnimationL(@"(,------.,--./ ,--,'  \     .'_        .-'),-----.    ,------.       \     .'_ (,------.,--.   ,--.).-'),-----. ");
                TypeAnimationR(@" |  .---'|   \ |  |\  ,`'--..._)      ( OO'  .-.  '('-| _.---'       ,`'--..._) |  .---'|   `.'   |( OO'  .-.  '");
                TypeAnimationL(@" |  |    |    \|  | ) |  |  \  '      /   |  | |  |(OO|(_\           |  |  \  ' |  |    |         |/   |  | |  |");
                TypeAnimationR(@"(|  '--. |  .     |/  |  |   ' |      \_) |  |\|  |/  |  '--.        |  |   ' |(|  '--. |  |'.'|  |\_) |  |\|  |");
                TypeAnimationL(@" |  .--' |  |\    |   |  |   / :        \ |  | |  |\_)|  .--'        |  |   / : |  .--' |  |   |  |  \ |  | |  |");
                TypeAnimationR(@" |  `---.|  | \   |   |  '--'  /         `'  '-'  '  \|  |_)         |  '--'  / |  `---.|  |   |  |   `'  '-'  '");
                TypeAnimationL(@" `------'`--'  `--'   `-------'            `-----'    `--'           `-------'  `------'`--'   `--'     `-----' ");
        }
        public static void TypeAnimationL(string str) {
            
            for (int i = 0; i < str.Length; i++) {
                Console.Write(str[i]);
                for (int j = 0; j < 1000000; j++) ;
            }
            Console.WriteLine();
        }
        public static void TypeAnimationR(string str) {
            for (int i = str.Length - 1; i >= 0; --i) {
                Console.SetCursorPosition(i, Console.CursorTop);
                Console.Write(str[i]);
                for (int j = 0; j < 1000000; ++j) ;
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
                for (int k = 0; k < 13000000; ++k) ;
            }
        }
    }
}
