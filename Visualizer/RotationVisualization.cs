using UnityEngine;
using Unity.Mathematics;

namespace MathUtils.Visualizer {

    /// <summary>
    /// Draws and visualizes a point rotated about a pivot.
    /// </summary>
    public class RotationVisualization : MonoBehaviour {

        public float radius = 0.1f;
        public float3 point, pivot, angle;
        public Color pointColor = Color.green, pivotColor = Color.red, rotatedPointColor = Color.cyan;

        private void OnDrawGizmos() {
            Gizmos.color = pointColor;
            Gizmos.DrawSphere(point, radius);

            Gizmos.color = pivotColor;
            Gizmos.DrawSphere(pivot, radius);

            Gizmos.color = rotatedPointColor;
            var rotatedPoint = RotationUtils.RotateAbout(pivot, point, angle);
            Gizmos.DrawSphere(rotatedPoint, radius);
        }
    }
}
