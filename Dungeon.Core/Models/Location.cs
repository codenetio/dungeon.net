namespace Dungeon.Core.Models
{
    public class Location
    {
        // eventually have Dungeon Level, X, Y, etc.
        // Dungeon Level = the floor level.
        // X,Y = the grid location of the room in maybe a 3x3, 4x4, or 5x5 dungeon level grid layout.
        /// <summary>
        /// Gets or sets the dungeon level.
        /// </summary>
        /// <value>
        /// The dungeon level.
        /// </value>
        public int Level { get; set; }

        /// <summary>
        /// Gets or setes the x location of the dungeon level grid.
        /// </summary>
        /// <value>
        /// The x location of the dungeon level grid.
        /// </value>
        public int X { get; set; }
        /// <summary>
        /// Gets or setes the y location of the dungeon level grid.
        /// </summary>
        /// <value>
        /// The y location of the dungeon level grid.
        /// </value>
        public int Y { get; set; }
    }
}