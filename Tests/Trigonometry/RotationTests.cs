using Unity.Mathematics;
using UnityEngine;
using NUnit.Framework;

namespace MathUtils.Tests {

    /// <summary>
    /// Tests simple rotations about an axis.
    /// </summary>
    public class RotationTests {

        [Test]
        public void APointRotatedAlongZWithZeroDegreesIsInFront() {
            var pivot = new float3(0, 0, 0);
            var rotatedPoint = RotationUtils.RotateAbout(pivot, 0f, 1f);

            Debug.LogFormat("<color=#00ff00ff>Pivot: {0}, Rotated Point: {1}</color>", pivot, rotatedPoint);

            Assert.Less(pivot.z, rotatedPoint.z, "The rotated point is not in front of the pivot!");
        }

        [Test]
        public void APointRotatedAlongZWith180DegreesIsInBack() {
            var pivot = new float3(0, 0, 1f);
            var rotatedPoint = RotationUtils.RotateAbout(pivot, 180f, 1f);

            Debug.LogFormat("<color=#00ff00ff>Pivot: {0}, Rotated Point: {1}</color>", pivot, rotatedPoint);

            Assert.Greater(pivot.z, rotatedPoint.z, "The rotated point is not behind the pivot!");
        }

        [Test]
        public void APointRotatedAlongZWith90DegreesIsLeft() {
            var pivot = new float3(0, 0, 0);
            var rotatedPoint = RotationUtils.RotateAbout(pivot, 90, 1f);

            Debug.LogFormat("<color=#00ff00ff>Pivot: {0}, Rotated Point: {1}</color>", pivot, rotatedPoint);

            Assert.Greater(pivot.x, rotatedPoint.z, "The rotated point is not to the left of the pivot!");
        }

        [Test]
        public void APointRotatedAlongZWith270DegreesIsRight() {
            var pivot = new float3(-1f, 0, 0);
            var rotatedPoint = RotationUtils.RotateAbout(pivot, 270, 1f);

            Debug.LogFormat("<color=#00ff00ff>Pivot: {0}, Rotated Point: {1}</color>", pivot, rotatedPoint);

            Assert.Less(pivot.x, rotatedPoint.z, "The rotated point is not to the right of the pivot!");
        }

        [Test]
        public void APointRotatedAlongZWithForwardIsRotatedBackwards() {
            var pivot = new float3();
            var forward = new float3(0, 0, 1f);

            var rotatedPoint = RotationUtils.RotateAbout(pivot, forward, new float3(0, 180f, 0));

            Debug.LogFormat("<color=#00ff00ff>Pivot: {0}, Rotated Point: {1}</color>", pivot, rotatedPoint);
            
            Assert.GreaterOrEqual(pivot.z, rotatedPoint.z, "The rotated point is not behind the pivot!");
        }
    }
}
