using System;
using System.Collections.Generic;
using System.Linq;

namespace Dungeon.Core.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public IList<Enemy> Enemies { get; set; } 
        public IList<Item> Items { get; set; }
        public IList<RoomExit> Exits { get; set; }
        
        public string Description()
        {
            var enemyText = Enemies.Count == 0 ? string.Empty : "  You see ";
            for (var i = 0; i < Enemies.Count; i++)
            {
                var targetIndex = i + 1;
                if (i == Enemies.Count - 1)
                {
                    if (i != 0)
                    {
                        enemyText += $"and [{targetIndex}] {Enemies[i].ShortDescription}.";
                    }
                    else
                    {
                        enemyText += $"[{targetIndex}] {Enemies[i].ShortDescription}.";
                    }
                }
                else
                {
                    enemyText += $"[{targetIndex}] {Enemies[i].ShortDescription}, ";
                }
            }
            
            var exitText = Exits.Count > 0
                ? "  There are exits in the following directions: " +
                  Exits.Select(e => e.Direction.ToString()).Aggregate((i, j) => i + ", " + j) + "."
                : string.Empty;
            return $"The room is dimly lit by two torches on the east and west walls.{enemyText}{exitText}";
        }
    }
}
