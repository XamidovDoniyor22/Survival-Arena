using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMechanism : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    private void Start()
    {
        _animator = GameObject.Find("Player").GetComponent<Animator>();

    }
    public void SwordMechanismForPlayer()
    {
        StartCoroutine(SwordWait());
    }
    private IEnumerator SwordWait()
    {
        _animator.SetBool("IsAttack", true);
        yield return new WaitForSeconds(0.5f);
        _animator.SetBool("IsAttack", false);
    }
}
