using System;

namespace Dungeon.Core.Entities
{
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the identifier of the entity.
        /// </summary>
        /// <value>
        /// The identifier of the entity.
        /// </value>
        Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        /// <value>
        /// The name of the entity.
        /// </value>
        string Name { get; set; }
        /// <summary>
        /// Gets or sets the armor class of the entity.
        /// </summary>
        /// <value>
        /// The armor class of the entity.
        /// </value>
        int ArmorClass { get; set; }

        /// <summary>
        /// Gets or sets the hit points of the entity.
        /// </summary>
        /// <value>
        /// The hit points of the entity.
        /// </value>
        int HitPoints { get; set; }
    }
}
