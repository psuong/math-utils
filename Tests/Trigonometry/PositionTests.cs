using NUnit.Framework;
using Unity.Mathematics;

namespace MathUtils.Tests {
    
    /// <summary>
    /// Simple tests to check the sign of a direction.
    /// </summary>
    public class PositionTests {
        
        [Test]
        public void APointLeftOfADirectionIsNegOne() {
            var forward = new float3(0, 0, 1);
            var left = new float3(-1, 0, 0);
            var sign = PositionUtils.GetRelativeDirection(forward, left, math.up());
            
            Assert.AreEqual(sign, -1, "Sign mismatch, should return -1 for a point left of the direction!");
        }

        [Test]
        public void APointRightOfADirectionIsPosOne() {
            var forward = new float3(0, 0, 1);
            var right = new float3(1, 0, 0);
            var sign = PositionUtils.GetRelativeDirection(forward, right, math.up());

            Assert.AreEqual(sign, 1, "Sign mismatch, should return 1 for a point right of the direction!");
        }

        [Test]
        public void APointForwardOfADirectionIsZero() {
            var forward = new float3(0, 0, 1);
            var sign = PositionUtils.GetRelativeDirection(forward, 2 * forward, math.up());

            Assert.AreEqual(sign, 0, "Sign mismatch, should return 0 for a point in front of the direction!");
        }

        [Test]
        public void APointBackwardOfADirectionIsZero() {
            var forward = new float3(0, 0, 1);
            var sign = PositionUtils.GetRelativeDirection(forward, -forward, math.up());

            Assert.AreEqual(sign, 0, "Sign mismatch, should return 0 for a point in front of the direction!");
        }
    }
}
