using System;

namespace Dungeon.Core.Models
{
    /// <summary>
    /// An enemy
    /// </summary>
    public abstract class Enemy
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the type of enemy.
        /// </summary>
        /// <value>
        /// The type of enemy.
        /// </value>
        public EnemyType Type { get; set; }
        /// <summary>
        /// Gets or sets the name of the enemy.
        /// </summary>
        /// <value>
        /// The name of the enemy.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the armor class.
        /// </summary>
        /// <value>
        /// The armor class.
        /// </value>
        public int ArmorClass { get; set; }

        /// <summary>
        /// Gets or sets the hit points of the enemy.
        /// </summary>
        /// <value>
        /// The hit points of the enemy.
        /// </value>
        public int HitPoints { get; set; }

        /// <summary>
        /// Attacks this instance.
        /// </summary>
        /// <returns>The result of the attack.</returns>
        public abstract AttackResult Attack();
    }
}
