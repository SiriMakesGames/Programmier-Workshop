using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerLoop : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPosition;

    private void Start() 
    {
        StartCoroutine(SpawnWithDelay());
    }

    private IEnumerator SpawnWithDelay()
    {
        for (var i = 0; i < 3; i++)
        {
            // Debug.Log("SpawnWithDelay");
            yield return new WaitForSeconds(0.2f);
            Instantiate(ballPrefab, spawnPosition);
        }
    }

}
