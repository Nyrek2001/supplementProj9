using System;
using System.Collections;
using System.Collections.Generic;


namespace SequenceGenerator
{
    /// <summary>
    /// Generates a sequence of floating-point numbers in the range of 0.0 to 1.0.
    /// Throws an InvalidSequenceException if three consecutive numbers are <= 0.5.
    /// </summary>
    public class SequenceGenerator : IEnumerable<double>
    {
        /// <summary>
        /// Returns an enumerator that generates a sequence of numbers.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
        {
            Random rand = new Random();
            int lowCount = 0; // Tracks consecutive numbers <= 0.5

            while (true)
            {
                double number = rand.NextDouble(); // Generates a number between 0.0 and 1.0
                yield return number;

                // If the number is less than or equal to 0.5, increase the count
                if (number <= 0.5)
                {
                    lowCount++;
                    if (lowCount >= 3)
                    {
                        // If three consecutive numbers are <= 0.5, throw an exception
                        throw new InvalidSequenceException();
                    }
                }
                else
                {
                    // Reset the count when we get a number greater than 0.5
                    lowCount = 0;
                }
            }
        }

        // Required for non-generic collections
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
