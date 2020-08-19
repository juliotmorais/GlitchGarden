using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    EnemySpawner myLaneSpawner;

    void Start()
    {
        SetLaneSpawner();
    }
    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("shoot it!");
        }
        else
        {
            Debug.Log("conserve fire");
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
