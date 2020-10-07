using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public class Room {
        public string Name { get; set; }
        public string Info { get; set; }
        public bool IsEndPoint { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Door> Doors { get; set; } = new List<Door>();
        
        public Room(string name, string info, bool isendpoint) {
            Name = name;
            Info = info;
            IsEndPoint = isendpoint;
        }
        public void PrintItems() {
            if (Items.Count > 0) {
                Console.Write($"{this.Name} contains: ");
                foreach (var item in Items) {
                    Console.Write($"{item.Name}\t");
                }
                Console.WriteLine();
            }
            else {
                Console.WriteLine($"{this.Name} contains no items.");
            }
        }
    }
}
