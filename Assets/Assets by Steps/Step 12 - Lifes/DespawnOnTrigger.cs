using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnOnTrigger : MonoBehaviour
{
    [SerializeField] LifeCounter lifeCounter;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.tag != "Ball")
        {
            return;
        }

        lifeCounter.ReduceLife();
        Destroy(collider2D.gameObject);
    }
}
