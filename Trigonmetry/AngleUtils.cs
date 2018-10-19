using Unity.Mathematics;

namespace MathUtils {

    public struct VectorUtils {

        public static float Angle(float3 from, float3 to) {
            var dot = math.dot(from, to);
            var mag = math.sqrt(from.x * from.x + from.y * from.y + from.z * from.z) * 
                math.sqrt(to.x * to.x + to.y * to.y + to.z * to.z);

            var cosTheta = dot / mag;
            return math.acos(cosTheta) * 180f / (float)math.PI;
        }
    }
}
