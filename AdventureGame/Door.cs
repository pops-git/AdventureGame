using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame {
    public class Door {
        public string Name { get; set; }
        public string CardinalDirection { get; set; }
        public bool IsOpen { get; set; }
        public Room LeadsTo { get; set; }
        public Door(string name, string cardinaldirection, bool isopen, Room leadsto) {
            Name = name;
            CardinalDirection = cardinaldirection;
            IsOpen = isopen;
            LeadsTo = leadsto;
        }
    }
}
