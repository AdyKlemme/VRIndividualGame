using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // Reference to the enemy prefab
    private GameObject spawnedEnemy; // Reference to the currently spawned enemy
    private float minSpawnDistance = 5f; // Minimum spawn distance from the last enemy's death point

    public int Kills = 0;

    private void Start()
    {
        SpawnEnemy();
        SpawnEnemy();
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = GetRandomSpawnPosition();
        spawnedEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    Vector3 GetRandomSpawnPosition()
    {
        Vector3 lastEnemyPosition = spawnedEnemy != null ? spawnedEnemy.transform.position : transform.position;
        Vector2 randomOffset = UnityEngine.Random.insideUnitCircle.normalized * minSpawnDistance;
        Vector3 randomSpawnPosition = lastEnemyPosition + new Vector3(randomOffset.x, 0, randomOffset.y);
        return randomSpawnPosition;
    }

    public void Spawn ()
    {
        SpawnEnemy();
    }

    public void KillCount()
    {
        Kills = Kills + 1;
    }
}

