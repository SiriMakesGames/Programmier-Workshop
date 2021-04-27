using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnOnTriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D collider2D)
    {
        if(collider2D.gameObject.layer != 8){
            return;
        }

        Destroy(collider2D.gameObject);
    }
}
