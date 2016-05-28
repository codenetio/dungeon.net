using System;
using Dungeon.Core.Enemies;
using Dungeon.Core.Models;

namespace Dungeon.Core.Utilities
{
    public static class EnemyGenerator
    {
        public static Enemy CreateEnemy(int roomLevel)
        {
            return new Goblin();
        }
    }
}
