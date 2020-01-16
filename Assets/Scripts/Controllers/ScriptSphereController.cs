using UnityEngine;

namespace Controllers {
    public class ScriptSphereController : MonoBehaviour {
        private Transform sphereTransform;

        private void Awake() {
            sphereTransform = transform;
        }

        private void Update() {
            Vector3 position = sphereTransform.position;
            sphereTransform.position = new Vector3(position.x, position.y + 0.01f, position.z);
        }
    }
}