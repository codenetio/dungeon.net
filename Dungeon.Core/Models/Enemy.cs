using System;

namespace Dungeon.Core.Models
{
    public class Enemy
    {
        public Guid Id { get; set; }
        public EnemyType Type { get; set; }
        public string Name { get; set; }
    }
}
