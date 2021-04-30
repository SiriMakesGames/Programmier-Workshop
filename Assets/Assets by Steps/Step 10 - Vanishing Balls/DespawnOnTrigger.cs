using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  Step10
{
    public class DespawnOnTrigger : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collider2D)
        {
            if(collider2D.gameObject.tag != "Ball")
            {
                return;
            }

            Destroy(collider2D.gameObject);
        }
    }
}

