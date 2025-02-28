using System;

namespace SequenceGenerator
{
    /// <summary>
    /// Represents a quarter in the range [0.0, 1.0).
    /// Allows comparison of quarters based on the quarter they belong to.
    /// </summary>
    public class Quarter
    {
        private readonly float value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Quarter"/> class.
        /// </summary>
        /// <param name="value">The value of the quarter (should be between 0.0 and 1.0).</param>
        public Quarter(float value)
        {
            if (value < 0.0f || value >= 1.0f)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0.0 and 1.0.");
            }
            this.value = value;
        }

        /// <summary>
        /// Determines the quarter of the number in the range [0.0, 1.0).
        /// </summary>
        private int GetQuarter()
        {
            if (value >= 0.0f && value < 0.25f) return 0;  // First quarter [0.0, 0.25)
            if (value >= 0.25f && value < 0.5f) return 1;   // Second quarter [0.25, 0.5)
            if (value >= 0.5f && value < 0.75f) return 2;   // Third quarter [0.5, 0.75)
            return 3;  // Fourth quarter [0.75, 1.0)
        }

        #region Operator Overloads

        public static bool operator ==(Quarter q1, Quarter q2) => q1.GetQuarter() == q2.GetQuarter();
        public static bool operator !=(Quarter q1, Quarter q2) => !(q1 == q2);

        public static bool operator >(Quarter q1, Quarter q2) => q1.GetQuarter() > q2.GetQuarter();
        public static bool operator <(Quarter q1, Quarter q2) => q1.GetQuarter() < q2.GetQuarter();

        public static bool operator >=(Quarter q1, Quarter q2) => q1.GetQuarter() >= q2.GetQuarter();
        public static bool operator <=(Quarter q1, Quarter q2) => q1.GetQuarter() <= q2.GetQuarter();

        #endregion

        public override bool Equals(object obj)
        {
            return obj is Quarter quarter && this == quarter;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}
