using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPosition;

    private void Start() 
    {
        Instantiate(ballPrefab, spawnPosition.position, Quaternion.identity);
    }

}
