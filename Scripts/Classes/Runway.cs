using System;

namespace ProjectHangarQueens
{
    /// <summary> Describes a Runway where planes can land. </summary>
    [Serializable]
    public class Runway
    {
        #region PROPERTIES

        /// <summary> Surface type of this Runway. </summary>
        public RunwayTypes Type { get; private set; }
        /// <summary> The Length, in feet, of this Runway. </summary>
        public int Length { get; private set; }

        #endregion
    }
}