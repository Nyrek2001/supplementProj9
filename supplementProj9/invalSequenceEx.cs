using System;

namespace SequenceGenerator
{
    /// <summary>
    /// Custom exception thrown when an invalid sequence is generated.
    /// </summary>
    public class InvalidSequenceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the InvalidSequenceException class.
        /// </summary>
        public InvalidSequenceException() : base("Invalid sequence generated: Three consecutive numbers are <= 0.5.")
        {
        }
    }
}
