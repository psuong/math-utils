using NUnit.Framework;
using Unity.Mathematics;

namespace MathUtils.Tests {
    
    public class AngleTests {
        
        [Test]
        public void RightAndUpMakePerpendicular() {
            var forward = new float3(0, 0, 1);
            var right = new float3(1, 0, 0);

            var angle = VectorUtils.Angle(forward, right);
            Assert.AreEqual(angle, 90, "Angle mismatch!");
        }
    }
}
