using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(this.CurrentRoom.Info);
        }
        public void CheckBag() {
            if (this.Bag.Count > 0) {
                string itemsInBag = "Your bag contains: ";
                foreach (var item in Bag) {
                    itemsInBag += $"{item.Name}, ";
                }
                Console.WriteLine(itemsInBag.Remove(itemsInBag.Length - 2));
            }
            else {
                Console.WriteLine("There are no items in your bag.");
            }
        }
        public void PrintCommands() {
            Console.WriteLine("Your commands are: Bag, Go, Get, Drop, Use, Look, Inspect, Help");
        }
        public void Look() {
            Console.WriteLine(this.CurrentRoom.Info);
            if (this.CurrentRoom.Items.Count > 0) {
                string itemsInRoom = "";
                foreach (var item in this.CurrentRoom.Items) {
                    itemsInRoom += $"{item.Name}, ";
                }
                Console.WriteLine($"{this.CurrentRoom.Name} items: {itemsInRoom.Remove(itemsInRoom.Length - 2)}.");
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
                Console.WriteLine($"You got {item.Name}!");
            }
            else {
                Console.WriteLine($"{this.CurrentRoom.Name} does not contain that item.");
            }
            
        }
        public void DropItem(Item item) {
            this.CurrentRoom.Items.Add(item);
            this.Bag.Remove(item);
            Console.WriteLine($"You dropped {item.Name} in {this.CurrentRoom.Name}");
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
                Console.WriteLine($"You got {this.Bag.Last().Name} from {item2.Name}.");
            }
            else {
                Console.WriteLine($"Unable to use {item1.Name} on {item2.Name}.");
            }
        }
        public void UseItemOnDoor(Item item, Door door) {
            if (item == null || door == null) {
                Console.WriteLine("");
            }
            if (MyWorld.IsOpenable(item.Name, door.Name)) {
                door.IsOpen = true;
                Console.WriteLine($"{door.Name} is now unlocked.");
            }
            else {
                Console.WriteLine($"Unable to open {door.Name} with {item.Name}.");
            }
        }
        public void Go(string direction) {
            bool canGo = false;
            foreach (var door in this.CurrentRoom.Doors) {
                if (door.CardinalDirection.ToLower() == direction.ToLower() && door.IsOpen) {
                    this.CurrentRoom = door.LeadsTo;
                    Console.WriteLine(this.CurrentRoom.Info);
                    canGo = true;
                    if (this.CurrentRoom.IsEndPoint) {
                        Console.WriteLine("\nYou beat the demo!");
                    }
                }
                else if (door.CardinalDirection.ToLower() == direction.ToLower() && !door.IsOpen) {
                    Console.WriteLine($"{door.Name} is locked.");
                }
            }
            if (!canGo) {
                Console.WriteLine($"Unable to go {direction}");
            }
        }
    }
}
