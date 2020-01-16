using UnityEngine;

namespace Controllers {
    [RequireComponent(typeof(Animator))]
    public class AnimSphereController : MonoBehaviour {
        private Animator animator;

        private void Awake() {
            animator = GetComponent<Animator>();
        }

        private void Start() {
            animator.SetBool("isWaiting", true);
        }
    }
}