using Xunit;
using SequenceGenerator;

namespace SequenceGeneratorTests
{
    public class SequenceGeneratorTests
    {
        [Fact]
        public void TestInvalidSequenceExceptionThrown()
        {
            var generator = new SequenceGenerator();
            var exceptionThrown = false;

            try
            {
                // Limit the iteration to avoid infinite loops
                int count = 0;
                foreach (var number in generator)
                {
                    count++;
                    if (count >= 100) break; // Test with 100 numbers for safety
                }
            }
            catch (InvalidSequenceException)
            {
                exceptionThrown = true;
            }

            Assert.True(exceptionThrown);
        }

        [Fact]
        public void TestSequenceGeneratesValuesInRange()
        {
            var generator = new SequenceGenerator();
            var count = 0;

            foreach (var number in generator)
            {
                Assert.InRange(number, 0.0, 1.0);
                count++;
                if (count >= 10) break; // Limit iterations to avoid infinite loop
            }
        }
    }
}
