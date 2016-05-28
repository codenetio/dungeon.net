namespace Dungeon.Core.Utilities
{
    /// <summary>
    /// Represents a single roll of a die.
    /// </summary>
    public class DieRoll
    {

        /// <summary>
        /// Gets or sets the type of die used.
        /// </summary>
        /// <value>
        /// The type of die used.
        /// </value>
        public DiceType Type { get; set; }
        /// <summary>
        /// Gets or sets the number that was rolled
        /// </summary>
        /// <value>
        /// The number that was rolled.
        /// </value>
        public int Roll { get; set; }
    }
}