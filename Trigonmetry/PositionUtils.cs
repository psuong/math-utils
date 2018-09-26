using Unity.Mathematics;

namespace MathUtils {

    public static class PositionUtils {
        
        /// <summary>
        /// Determines if a direction is left, right, forward or backwards of a position.
        /// </summary>
        /// <param name="forward"></param>
        /// <param name="direction"></param>
        /// <param name="normal"></param>
        /// <returns>-1 for left, 1 for right, 0 for forward/backward</returns>
        public static int GetRelativeDirection(float3 forward, float3 direction, float3 normal) {
            var perp = math.cross(forward, direction);
            var dir = math.dot(perp, normal);
            var sign = 0;

            if (dir > 0f)
                sign = 1;
            if (dir < 0f)
                sign = -1;

            return sign;
        }
    }
}
