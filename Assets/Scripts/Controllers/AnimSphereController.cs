using UnityEngine;

namespace Controllers {
    [RequireComponent(typeof(Animator))]
    public class AnimSphereController : MonoBehaviour {
        private Animator animator;
        private static readonly int IsWaiting = Animator.StringToHash("isWaiting");

        private void Awake() {
            animator = GetComponent<Animator>();
        }

        private void Start() {
            animator.SetBool(IsWaiting, true);
        }
    }
}