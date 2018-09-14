using Unity.Mathematics;

namespace MathUtils {

    public static class RotationUtils {

        /// <summary>
        /// Rotates a point about an angle.
        /// </summary>
        /// <param name="rotation">The amount to rotate by.</param>
        /// <param name="point">The point to rotate.</param>
        /// <returns>A float3 representation of the rotated point.</returns>
        public static float3 RotateAbout(quaternion rotation, float3 point) {
            return RotateAbout(rotation.value, point);
        }

        /// <summary>
        /// Rotates a point given a quaternion rotation.
        /// </summary>
        /// <param name="rotation">The xyzw rotation to apply.</param>
        /// <param name="point">Which point is getting rotated?</param>
        /// <returns>A float3 representation of the rotated point.</returns>
        public static float3 RotateAbout(float4 rotation, float3 point) {
            float num = rotation.x * 2f;
            float num2 = rotation.y * 2f;
            float num3 = rotation.z * 2f;
            float num4 = rotation.x * num;
            float num5 = rotation.y * num2;
            float num6 = rotation.z * num3;
            float num7 = rotation.x * num2;
            float num8 = rotation.x * num3;
            float num9 = rotation.y * num3;
            float num10 = rotation.w * num;
            float num11 = rotation.w * num2;
            float num12 = rotation.w * num3;
            float3 result;
            result.x = (1f - (num5 + num6)) * point.x + (num7 - num12) * point.y + (num8 + num11) * point.z;
            result.y = (num7 + num12) * point.x + (1f - (num4 + num6)) * point.y + (num9 - num10) * point.z;
            result.z = (num8 - num11) * point.x + (num9 + num10) * point.y + (1f - (num4 + num5)) * point.z;
            return result;
        }

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

        /// <summary>
        /// Performs a rotation along an angle axis.
        /// </summary>
        /// <param name="pivot">The pivot point to rotate about.</param>
        /// <param name="point">The point to rotate.</param>
        /// <param name="angle">The euler angle used to rotate.</param>
        /// <returns>A point rotated about a pivot given an angle.</returns>
        public static float3 RotateAbout(float3 pivot, float3 point, float3 angle) {
            var direction = RotateAbout(quaternion.euler(angle), point - pivot);
            return point + direction;
        }
    }
}
