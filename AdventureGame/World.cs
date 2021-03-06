﻿using System.Collections.Generic;
using System.Linq;

namespace AdventureGame {
    public class World {
        public Player player { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
        public Dictionary<string, string> OpenableDoors { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> KeywordPairs { get; set; } = new Dictionary<string, string>();
        public List<string> Keywords { get; set; } = new List<string>();
        public World(string playername) {
            CreateRooms();
            CreateDoors();
            CreateItems();
            SetOpenableDoorsPairs();
            SetKeywords();
            SetKeywordPairs();
            player = new Player(playername, this);
        }
        public void CreateRooms() {
            Rooms.AddRange(new List<Room> {
                new Room("livingroom", "you find yourself in a large dusty livingroom.\nthe wooden floor is uneaven and there are barely any furniture in the room.\n" +
                "there are two doors, one to the north and one to the east. the northern door seems slightly open.", false),
                new Room("kitchen", "you find yourself in a small kitchen.\nthe refrigerator is wide open and you can see it containing smelly leftovers from god-knows-when.\n" +
                "there is but one door in the kitchen, the southern one you just came from.", false),
                new Room("cellar", "you find yourself in a pitch black cellar...", true)
            });
        }
        public void CreateDoors() {
            Rooms.Where(room => room.Name == "livingroom").FirstOrDefault().Doors.Add(new Door("kitchen-door", "north", true, Rooms.Where(room => room.Name == "kitchen").FirstOrDefault()));
            Rooms.Where(room => room.Name == "livingroom").FirstOrDefault().Doors.Add(new Door("cellar-door", "east", false, Rooms.Where(room => room.Name == "cellar").FirstOrDefault()));
            Rooms.Where(room => room.Name == "kitchen").FirstOrDefault().Doors.Add(new Door("livingroom-door", "south", true, Rooms.Where(room => room.Name == "livingroom").FirstOrDefault()));
        }
        public void CreateItems() {
            Room kitchen = Rooms
                .Where(room => room.Name == "kitchen")
                .FirstOrDefault();
            Room livingroom = Rooms
                .Where(room => room.Name == "livingroom")
                .FirstOrDefault();

            kitchen.Items.Add(
                new Item("box", "small wooden box that appears to be able to break if any force is applied to it.",
                new Item("envelope", "envelope with something small but heavy inside.",
                new Item("silverkey", "shiny silver key that looks newly polished."))));

            livingroom.Items.Add(
                new Item("crowbar",
                kitchen.Items.Where(item => item.Name == "box").FirstOrDefault(),
                "rusty crowbar, seems functionable."));

            livingroom.Items.Add(new Item("letter-opener",
                Rooms.Where(room => room.Name == "kitchen").FirstOrDefault().Items.Where(item => item.ItemInside.Name == "envelope").FirstOrDefault().ItemInside,
                "sharp letter-opener, perfect for opening letters."));
        }
        public void SetOpenableDoorsPairs() {
            OpenableDoors.Add("silverkey", "cellar-door");
        }
        public void SetKeywords() {
            foreach (var room in Rooms) {
                foreach (var door in room.Doors) {
                    Keywords.Add(door.Name);
                }
                foreach (var item in room.Items) {
                    Keywords.Add(item.Name);
                    if (item.ItemInside != null) {
                        Keywords.Add(item.ItemInside.Name);
                    }
                }
            }
            Keywords.AddRange(new List<string> { "get", "drop", "use", "go", "north", "east", "south", "west", "look", "inspect", "help", "bag" });
        }
        public void SetKeywordPairs() {
            KeywordPairs.Add("crowbar", "box");
            KeywordPairs.Add("letter-opener", "envelope");
        }
        public bool CheckKeywordPair(string str1, string str2) {
            foreach (var kvp in KeywordPairs) {
                if (kvp.Key == str1 && kvp.Value == str2) {
                    return true;
                }
            }
            return false;
        }
        public bool IsOpenable(string str1, string str2) {
            foreach (var kvp in OpenableDoors) {
                if (kvp.Key == str1 && kvp.Value == str2) {
                    return true;
                }
            }
            return false;
        }
    }
}