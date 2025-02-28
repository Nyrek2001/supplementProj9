using Xunit;
using SequenceGenerator;

namespace SequenceGeneratorTests
{
    public class QuarterTests
    {
        [Fact]
        public void TestQuarterComparison()
        {
            var quarter1 = new Quarter(0.1f);
            var quarter2 = new Quarter(0.2f);
            var quarter3 = new Quarter(0.6f);
            var quarter4 = new Quarter(0.75f);

            // Assert quarters are considered equal if they fall into the same range
            Assert.True(quarter1 == quarter2);  // Same quarter
            Assert.True(quarter3 > quarter2);   // Quarter3 is greater than quarter2
            Assert.True(quarter4 <= quarter3);  // Quarter4 is less than or equal to quarter3
        }

        [Fact]
        public void TestQuarterEqualityWithDifferentValues()
        {
            var quarter1 = new Quarter(0.3f);
            var quarter2 = new Quarter(0.4f);
            var quarter3 = new Quarter(0.8f);

            Assert.True(quarter1 == quarter2); // Both are in the same quarter (0.25 - 0.5)
            Assert.False(quarter2 == quarter3); // Different quarters
        }
    }
}
