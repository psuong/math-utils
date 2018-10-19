using NUnit.Framework;
using Unity.Mathematics;

namespace MathUtils.Tests {
    
    /// <summary>
    /// Tests common numerical operations found in the NumericUtils class.
    /// </summary>
    public class NumericsTests {

        [Test]
        public void DefaultRoundTest() {
            var third = 100f / 3f;
            var v = new float3(third, third, third);

            var output = NumericsUtil.Normalize(v);
            
            Assert.AreEqual(output, new float3(33.33f, 33.33f, 33.33f), "Value mismatch!");
        }
    }
}