using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventureGame {
    public class Player {
        public string Name { get; set; }
        public List<Item> Bag { get; set; } = new List<Item>();
        public Room CurrentRoom { get; set; }
        public World MyWorld { get; set; }

        public Player(string name, World myworld) {
            Name = name;
            MyWorld = myworld;
            CurrentRoom = MyWorld.Rooms.Where(room => room.Name == "livingroom").FirstOrDefault();
            Art.LivingroomArt();
            PrintCommands();
            Console.WriteLine(this.CurrentRoom.Info);
        }
        public void CheckBag() {
            if (this.Bag.Count > 0) {
                string itemsInBag = "your bag contains: ";
                foreach (var item in Bag) {
                    itemsInBag += $"{item.Name}, ";
                }
                Console.WriteLine(itemsInBag.Remove(itemsInBag.Length - 2));
            }
            else {
                Console.WriteLine("there are no items in your bag.");
            }
        }
        public void PrintCommands() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" +
                "------------------------------------------------------------------------------------------------\n" +
                "|| bag                      checks your inventory || go              go north/west/east/south ||\n" +
                "|| get                      tries to pick up item || drop         tries to drop item from bag ||\n" +
                "|| use          use item on item in bag or a door || look            check what room contains ||\n" +
                "|| inspect                        inspect an item || help               prints these commands ||\n" +
                "------------------------------------------------------------------------------------------------\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void Look() {
            if (this.CurrentRoom.Items.Count > 0) {
                string itemsInRoom = "";
                foreach (var item in this.CurrentRoom.Items) {
                    itemsInRoom += $"{item.Name}, ";
                }
                Console.WriteLine($"{this.CurrentRoom.Name} items: {itemsInRoom.Remove(itemsInRoom.Length - 2)}");
            }
            else {
                Console.WriteLine($"no items in {this.CurrentRoom.Name}.");
            }
            if (this.CurrentRoom.Doors.Count > 0) {
                string doorsInRoom = "";
                foreach (var door in this.CurrentRoom.Doors) {
                    doorsInRoom += $"{door.Name}, ";
                }
                Console.WriteLine($"{this.CurrentRoom.Name} doors: {doorsInRoom.Remove(doorsInRoom.Length - 2)}");
            }
            else {
                Console.WriteLine($"no doors in {this.CurrentRoom.Name}.");
            }
        }
        public void GetItem(Item item) {
            if (this.CurrentRoom.Items.Contains(item)) {
                this.Bag.Add(item);
                this.CurrentRoom.Items.Remove(item);
                Console.WriteLine($"you got {item.Name}!");
            }
            else {
                Console.WriteLine($"{this.CurrentRoom.Name} does not contain that item.");
            }
            
        }
        public void DropItem(Item item) {
            this.CurrentRoom.Items.Add(item);
            this.Bag.Remove(item);
            Console.WriteLine($"you dropped {item.Name} in {this.CurrentRoom.Name}");
        }
        public void InspectItem(Item item) {
            if (item != null) {
                Console.WriteLine(item.Info);
            }
            else {
                Console.WriteLine("no such item exist in your bag.");
            }
        }
        public void UseItemOnItem(Item item1, Item item2) {
            if (item1 == null) {
                Console.WriteLine("the item you are trying to use does not exist in your bag.");
                return;
            }
            else if (item2 == null) {
                Console.WriteLine($"the item you are trying to use {item1.Name} on does not exist in your bag.");
                return;
            }
            else if (item1.UsableOn == item2) {
                Bag.Add(item2.ItemInside);
                MyWorld.Keywords.Add(item2.ItemInside.Name);
                foreach (var item in Bag) {
                    if (item == item2) {
                        item.Name = $"opened-{item.Name}";
                        item.ItemInside = null;
                        MyWorld.Keywords.Add(item.Name);
                    }
                }
                Console.WriteLine($"you got {this.Bag.Last().Name} from {item2.Name}.");
            }
            else {
                Console.WriteLine($"unable to use {item1.Name} on {item2.Name}.");
            }
        }
        public void UseItemOnDoor(Item item, Door door) {
            if (item == null) {
                Console.WriteLine("the item you are trying to use does not exist in your bag.");
                return;
            }
            else if (door == null) {
                Console.WriteLine($"the door you are trying to use {item.Name} on does not exist in your current room.");
                return;
            }
            else if (MyWorld.IsOpenable(item.Name, door.Name)) {
                door.IsOpen = true;
                Console.WriteLine($"{door.Name} is now unlocked.");
            }
            else {
                Console.WriteLine($"unable to open {door.Name} with {item.Name}.");
            }
        }
        public void Go(string direction) {
            bool canGo = false;
            foreach (var door in this.CurrentRoom.Doors) {
                if (door.CardinalDirection.ToLower() == direction.ToLower() && door.IsOpen) {
                    this.CurrentRoom = door.LeadsTo;
                    if (this.CurrentRoom.Name == "livingroom") {
                        Art.LivingroomArt();
                    }
                    if (this.CurrentRoom.Name == "kitchen") {
                        Art.KitchenArt();
                    }
                    this.PrintCommands();
                    Console.WriteLine(this.CurrentRoom.Info);
                    canGo = true;
                    if (this.CurrentRoom.IsEndPoint) {
                        Art.EndOfDemoArt();
                    }
                }
                else if (door.CardinalDirection.ToLower() == direction.ToLower() && !door.IsOpen) {
                    Console.WriteLine($"{door.Name} is locked.");
                }
            }
            if (!canGo) {
                Console.WriteLine($"unable to go {direction}");
            }
        }
    }
}
