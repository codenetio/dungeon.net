using System.Collections.Generic;

namespace Dungeon.Core.Utilities
{
    /// <summary>
    /// The result of a dice roll.
    /// </summary>
    public class RollResult
    {
        public RollResult()
        {
            Rolls = new List<DieRoll>();
        }

        /// <summary>
        /// Gets or sets the total roll amount.
        /// </summary>
        /// <value>
        /// The total roll amount.
        /// </value>
        public int Roll { get; set; }
        /// <summary>
        /// Gets or sets the individual die rolls.
        /// </summary>
        /// <value>
        /// The individual die rolls.
        /// </value>
        public IList<DieRoll> Rolls { get; set; }
    }
}