using UnityEngine;

namespace Controllers {
    public class ScriptSphereController : MonoBehaviour {
        [SerializeField] private float speed = 1f;
        [SerializeField] private float initialVerticalPosition = 0f;
        [SerializeField] private float finalVerticalPosition = 1f;

        private Transform sphereTransform;
        private float t;
        private bool isAscending;

        private void Awake() {
            sphereTransform = transform;
            t = 0f;
            isAscending = true;
        }

        private void Update() {
            Vector3 position = sphereTransform.position;

            if (isAscending) {
                t += speed * 0.01f;
                if (t >= 1f) isAscending = false;
            } else {
                t -= speed * 0.01f;
                if (t <= 0f) isAscending = true;
            }
            
            sphereTransform.position = new Vector3(
                position.x,
                Mathf.Lerp(initialVerticalPosition, finalVerticalPosition, t),
                position.z);
        }
    }
}