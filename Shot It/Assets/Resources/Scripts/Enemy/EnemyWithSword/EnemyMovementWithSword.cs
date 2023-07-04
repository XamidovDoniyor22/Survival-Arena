using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementWithSword : EnemyMovement
{
    [SerializeField]
    private Transform enemyTransform;
    [SerializeField]
    private Transform playerTransform;

    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private GameObject playerPrefab;

    [SerializeField]
    private float distance;

    [SerializeField]
    private bool isChasing;

    

    [SerializeField]
    private EnemyWithSwordAnimation animator;

    private void Start()
    {
        animator = GetComponent<EnemyWithSwordAnimation>();
        animator.AnimationAttackDisActive();
    }


    private void Update()
    {
        Chasing();
        FlipChecks();
        DistanceChecker();

        distance = Vector2.Distance(enemyPrefab.transform.position, playerPrefab.transform.position);

    }
    private void DistanceChecker()
    {
        if (distance <= 1.5)
        {
            isChasing = false;
            animator.AnimationAttckIsActive();
            animator.AnimationRunningDisActive();
        }
        else
        {
            isChasing = true;
            animator.AnimationAttackDisActive();
            animator.AnimationRunningIsActive();
        }
    }
    protected override void Chasing()
    {
        if(isChasing)
        {
        base.Chasing();
        animator.AnimationRunningIsActive();

        }

    }
    protected override void FlipChecks()
    {
        base.FlipChecks();
    }

}
