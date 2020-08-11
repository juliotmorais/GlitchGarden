﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay=1f;
    [SerializeField] float maxSpawnDelay=5f;
    [SerializeField] Attacker attackerPrefab;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {

            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }
}
