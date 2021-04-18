using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerLoopNumbered : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private int number;

    private void Start() 
    {
        Spawn();
    }

    public void Spawn()
    {
        StartCoroutine(SpawnWithDelay());
    }

    private IEnumerator SpawnWithDelay()
    {
        for (var i = 0; i < number; i++)
        {
            yield return new WaitForSeconds(0.2f);
            Instantiate(ballPrefab, spawnPosition.position, Quaternion.identity);
        }
    }

}
