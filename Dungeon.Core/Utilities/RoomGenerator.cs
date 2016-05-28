using System.Collections.Generic;
using Dungeon.Core.Models;

namespace Dungeon.Core.Utilities
{
    public static class RoomGenerator
    {
        public static Room CreateRoom(int roomLevel)
        {
            return new Room
            {
                Enemies = new List<Enemy>
                {
                    EnemyGenerator.CreateEnemy(roomLevel)
                },
                Location = new Location
                {
                    Level = roomLevel,
                    X = 2,
                    Y = 3
                },
                Exits = new List<RoomExit>
                {
                    new RoomExit
                    {
                        Direction = Direction.North,
                        Type = ExitType.Door
                    }
                }
            };
        }
    }
}
