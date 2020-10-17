namespace AdventureGame {
    public class Item {
        public string Name { get; set; }
        public string Info { get; set; }
        public Item ItemInside { get; set; }
        public Item UsableOn { get; set; }
        public Item(string name, string info) {
            Name = name;
            Info = info;
        }
        public Item(string name, string info, Item iteminside) {
            Name = name;
            Info = info;
            ItemInside = iteminside;
        }
        public Item(string name, Item usableon, string info) {
            Name = name;
            UsableOn = usableon;
            Info = info;
        }
    }
}
