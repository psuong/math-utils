using Unity.Mathematics;

namespace MathUtils {
    
    /// <summary>
    /// cCommon numerics utilities.
    /// </summary>
    public static class NumericsUtil {

        /// <summary>
        /// Normalises a float three to the nth power.
        /// </summary>
        /// <param name="v">The vector to normalise</param>
        /// <param name="nthPower">The power to </param>
        /// <returns>A normalised vector to the nth power.</returns>
        public static float3 Normalize(float3 v, int nthPower = 2) {
            var factor = math.pow(10, nthPower);
            return new float3(
                math.round(v.x * factor) / factor,
                math.round(v.y * factor) / factor,
                math.round(v.z * factor) / factor);
        }
    }
}