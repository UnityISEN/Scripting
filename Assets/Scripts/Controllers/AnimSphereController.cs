using System.Collections;
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
            StartCoroutine(ChangeAnimatorState());
        }

        private IEnumerator ChangeAnimatorState() {
            while (true) {
                animator.SetBool(IsWaiting, true);
                yield return new WaitForSeconds(5f);

                animator.SetBool(IsWaiting, false);
                yield return new WaitForSeconds(7f);
            }
        }
    }
}