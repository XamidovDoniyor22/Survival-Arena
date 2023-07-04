using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWithSwordAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();    
    }
    public void AnimationAttckIsActive()
    {
        animator.SetBool("IsAttack", true);
    }
    public void AnimationAttackDisActive()
    {
        animator.SetBool("IsAttack", false);
    }
    public void AnimationRunningIsActive()
    {
        animator.SetBool("IsRunning", true);
    }
    public void AnimationRunningDisActive()
    {
        animator.SetBool("IsRunning", false);
    }
}
