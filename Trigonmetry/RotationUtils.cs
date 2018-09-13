using Unity.Mathematics;

namespace MathUtils {

    public static class RotationUtils {

        /// <summary>
        /// Performs a rotation about a point along the Z axis given an angle (in degrees) and a radius).
        /// </summary>
        /// <param name="pivot">The point to rotate about along the z axis.</param>
        /// <param name="angle">The angle in degrees rotate about.</param>
        /// <param name="radius">How wide is the circle?</param>
        /// <param name="offset">How much offset should be placed on the angle? A 90 degree offset makes 0 degrees point forward.</param>
        public static float3 RotateAbout(float3 pivot, float angle, float radius, float offset = 90f) {
            var radians = math.radians(angle + offset);
            return new float3(math.cos(radians) * radius, 0f, math.sin(radians) * radius) + pivot;
        }
    }
}
