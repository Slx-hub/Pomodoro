using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickieAnimation : MonoBehaviour
{
    private Animator animator;
    void Start() {
        animator = gameObject.GetComponent<Animator>();
    }

    public void OnStickySelected() {
        if (animator != null)
            animator.SetBool("IsSelected", true);
    }

    public void OnStickyDeselected() {
        if (animator != null)
            animator.SetBool("IsSelected", false);
    }
}
