using UnityEngine;

namespace Controllers {
    public class ScriptSphereController : MonoBehaviour {
        private Transform sphereTransform;
        private float sinParameter;

        private void Awake() {
            sphereTransform = transform;
            sinParameter = 0f;
        }

        private void Update() {
            Vector3 position = sphereTransform.position;
            sinParameter += 0.01f;
            sphereTransform.position = new Vector3(position.x, Mathf.Sin(sinParameter), position.z);
        }
    }
}