using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public static class Interpreter {
        public static void Interpret(string str, World ng) {
            var input = str.Split(' ').ToList();
            List<string> inputList = new List<string>();
            bool hasDoor = false;
            foreach (var word in input) {
                if (ng.Keywords.Contains(word.ToLower())) {
                    if (word.Contains("door")) {
                        hasDoor = true;
                    }
                    inputList.Add(word.ToLower());
                }
            }
            if (inputList.Count == 3 && inputList.First() == "use" && !hasDoor) {
                ng.player.UseItemOnItem(ng.player.Bag.Where(item1 => item1.Name == inputList[1]).FirstOrDefault(), ng.player.Bag.Where(item2 => item2.Name == inputList[2]).FirstOrDefault());
            }
            else if (inputList.Count == 3 && inputList.First() == "use" && hasDoor) {
                ng.player.UseItemOnDoor(ng.player.Bag.Where(item1 => item1.Name == inputList[1]).FirstOrDefault(), ng.player.CurrentRoom.Doors.Where(door => door.Name == inputList[2]).FirstOrDefault());
            }
            else if (inputList.Count == 2 && inputList.First() == "get" && !hasDoor) {
                ng.player.GetItem(ng.player.CurrentRoom.Items.Where(item => item.Name == inputList[1]).FirstOrDefault());
            }
            else if (inputList.Count == 2 && inputList.First() == "drop" && !hasDoor) {
                ng.player.DropItem(ng.player.Bag.Where(item => item.Name == inputList[1]).FirstOrDefault());
            }
            else if (inputList.Count == 2 && inputList.First() == "inspect" && !hasDoor) {
                ng.player.InspectItem(ng.player.Bag.Where(item => item.Name == inputList[1]).FirstOrDefault());
            }
            else if (inputList.Count == 2 && inputList.First() == "go" && !hasDoor) {
                ng.player.Go(inputList[1]);
            }
            else if (inputList.Count == 1 && inputList.First() == "help" && !hasDoor) {
                ng.player.PrintCommands();
            }
            else if (inputList.Count == 1 && inputList.First() == "look" && !hasDoor) {
                ng.player.Look();
            }
            else if (inputList.Count == 1 && inputList.First() == "bag" && !hasDoor) {
                ng.player.CheckBag();
            }
            else {
                Console.WriteLine("Not a valid command.");
            }
        }
    }
}
