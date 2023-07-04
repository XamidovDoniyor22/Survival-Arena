using UnityEngine;

public class Playeranimation : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AnimationActive()
    {
        animator.SetBool("IsRunning", true);
    }
    public void AnimationDisactive()
    {
        animator.SetBool("IsRunning", false);
    }

}
