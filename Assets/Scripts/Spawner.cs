using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnCooldown;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        var spawnCooldown = new WaitForSeconds(_spawnCooldown);

        while (enabled)
        {
            SpawnEnemy();
            yield return spawnCooldown;
        }
    }

    private void SpawnEnemy()
    {
        int randomPointIndex = Random.Range(0, _spawnPoints.Count);
        _spawnPoints[randomPointIndex].Spawn();
    }
}
