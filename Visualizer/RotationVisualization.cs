using UnityEngine;
using Unity.Mathematics;

namespace MathUtils.Visualizer {

    /// <summary>
    /// Draws and visualizes a point rotated about a pivot.
    /// </summary>
    public class RotationVisualization : MonoBehaviour {

        [Tooltip("How wide is the circle?")]
        public float radius = 0.1f;
        [Tooltip("What are the points to pivot on and how wide is the rotation?")]
        public float3 point, pivot, angle;
        [Tooltip("What are the colors of these visualized points?")]
        public Color pointColor = Color.green, pivotColor = Color.red, rotatedPointColor = Color.cyan;

        private void OnDrawGizmos() {
            Gizmos.color = pointColor;
            Gizmos.DrawSphere(point, radius);

            Gizmos.DrawLine(pivot, point);

            Gizmos.color = pivotColor;
            Gizmos.DrawSphere(pivot, radius);

            Gizmos.color = rotatedPointColor;
            var rotatedPoint = RotationUtils.RotateAbout(pivot, point, angle);
            Gizmos.DrawSphere(rotatedPoint, radius);
            Gizmos.DrawLine(pivot, rotatedPoint);
        }
    }
}
