using System;

namespace Dungeon.Core.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the hitpoints.
        /// </summary>
        /// <value>
        /// The hitpoints.
        /// </value>
        public int HitPoints { get; set; }
        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets the armor class.
        /// </summary>
        /// <value>
        /// The armor class.
        /// </value>
        public int ArmorClass { get; set; }
        
    }
}
