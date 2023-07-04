using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<Transform> points;
    [SerializeField]
    private GameObject enemy;

    private void Start()
    {
        StartCoroutine(SpawnerEnemy());
    }

    private IEnumerator SpawnerEnemy()
    {
        while(true)
        {
            var pointsIndex = Random.Range(0, points.Count);

            Instantiate(enemy, points[pointsIndex].position, Quaternion.identity);
            yield return new WaitForSeconds(6.5f);
        }
    }
}
