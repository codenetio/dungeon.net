using System;
using Dungeon.Core.Models;

namespace Dungeon.Core.Utilities
{
    public static class EnemyGenerator
    {
        public static Enemy CreateEnemy(int roomLevel)
        {
            return new Enemy
            {
                Id = Guid.NewGuid(),
                Name = "Goblin",
                Type = EnemyType.Goblin,
                ArmorClass = 12,
                HitPoints = 5
            };
        }
    }
}
