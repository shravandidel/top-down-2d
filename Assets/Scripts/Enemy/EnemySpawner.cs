using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefabs;
    [SerializeField] private GameObject playerGameObject;
    [SerializeField] private float minX, maxX, minY, maxY;
    [SerializeField] private int totalSpawnPower;
    [SerializeField] private int initalSpawnPower;
    [SerializeField] private float spawnRate;

    private int spawnCount;
    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = spawnRate;

        for (int i = 0; i < initalSpawnPower; i++)
        {
            SpwanEnemy();
        }
    }

    void Update()
    {
        if (Time.time > nextSpawnTime && spawnCount < totalSpawnPower) {

            nextSpawnTime = Time.time + spawnRate;
            SpwanEnemy();
            spawnCount++;
        }
    }

    private void SpwanEnemy()
    {
        Vector3 position = (Vector3)GetRandomPosition();

        Enemy enemy = Instantiate(enemyPrefabs, position, Quaternion.identity).GetComponent<Enemy>();

        enemy.SetPlayerReference(playerGameObject);
    }

    Vector2 GetRandomPosition()
    {
        Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        return randomPos;
    }
}
