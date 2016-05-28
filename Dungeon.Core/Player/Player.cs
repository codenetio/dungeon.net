using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dungeon.Core.Entities;
using Dungeon.Core.Models;

namespace Dungeon.Core.Player
{
    public class Player : IEntity
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
