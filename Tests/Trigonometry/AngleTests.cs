using NUnit.Framework;
using Unity.Mathematics;

namespace MathUtils.Tests {
 
    /// <summary>
    /// Tests basic angle functions.
    /// </summary>   
    public class AngleTests {

        private float3 forward  = new float3(0, 0, 1);
        private float3 backward = new float3(0, 0, -1);
        private float3 right    = new float3(1, 0, 0);
        private float3 left     = new float3(-1, 0, 0);
        
        [Test]
        public void RightAndUpMakePerpendicular() {
            var forward = new float3(0, 0, 1);
            var right = new float3(1, 0, 0);

            var deg = VectorUtils.AngleDeg(forward, right);
            Assert.AreEqual(deg, 90, "Angle mismatch!");

            var rad = VectorUtils.Angle(forward, right);
            Assert.AreEqual(rad, (float)(math.PI / 2), "Angle mismatch!");
        }

        [Test]
        public void ForwardAndBackwardMakeHalf() {
            var deg = VectorUtils.AngleDeg(forward, backward);
            Assert.AreEqual(deg, 180f, "Angle mismatch!");

            var rad = VectorUtils.Angle(forward, backward);
            Assert.AreEqual(rad, (float)math.PI, "Angle mismatch!");
        }

        [Test]
        public void OneAndFourOClockMake120() {
            var fourOClock = RotationUtils.RotateAbout(float3.zero, 120, 1);
            var deg = VectorUtils.AngleDeg(forward, fourOClock);
            Assert.AreEqual(120, deg, "Angle mismatch!");

            var rad = VectorUtils.Angle(forward, fourOClock);
            Assert.AreEqual(120f * ((float)math.PI) / 180f, rad, "Angle mismatch!");
        }
    }
}
