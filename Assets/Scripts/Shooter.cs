using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    EnemySpawner myLaneSpawner;
    Animator animator;

    void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("shoot it!");
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            Debug.Log("conserve fire");
            animator.SetBool("IsAttacking", false);
        }
    }
    public void Fire(float damange)
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }

    private void SetLaneSpawner()
    {
        EnemySpawner[] spawners = FindObjectsOfType<EnemySpawner>();
        foreach (EnemySpawner spawn in spawners)
        {
            bool IsCloseEnough = (Math.Abs(spawn.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            if (IsCloseEnough)
            {
                myLaneSpawner = spawn;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
