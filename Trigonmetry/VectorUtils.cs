using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace MathUtils {

    public struct VectorUtils {

        /// <summary>
        /// Computes the angle between two vectors.
        /// </summary>
        /// <param name="from">The point of origin.</param>
        /// <param name="to">The destination vector.</param>
        /// <returns>The acute angle between two vectors in degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float AngleDeg(float3 from, float3 to) {
            return Angle(from, to) * 180f / (float)math.PI;
        }

        /// <summary>
        /// Computes the angle between two vectors.
        /// </summary>
        /// <param name="from">The point of origin.</param>
        /// <param name="to">The destination vector.</param>
        /// <returns>The acute angle between two vectors in degrees.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Angle(float3 from, float3 to) {
            var dot = math.dot(from, to);
            var mag = math.sqrt(from.x * from.x + from.y * from.y + from.z * from.z) * 
                math.sqrt(to.x * to.x + to.y * to.y + to.z * to.z);

            var cosTheta = dot / mag;
            return math.acos(cosTheta);
        }
    }
}
