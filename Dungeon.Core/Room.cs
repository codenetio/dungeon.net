using System;
using System.Collections.Generic;
using Dungeon.Core.Models;

namespace Dungeon.Core
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public IList<Enemy> Enemies { get; set; } 
        public IList<Item> Items { get; set; }
        public IList<RoomExit> Exits { get; set; }
    }
}
