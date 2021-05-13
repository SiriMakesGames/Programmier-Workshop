using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace step10
{
    public class SplitOnTriggerEnter : MonoBehaviour
    {
        public int numsplits = 2;
        public int randomForceStrength = 25;

        private void OnTriggerEnter2D(Collider2D collider2D)
        {
            if(collider2D.gameObject.tag != "Ball")
            {
                return;
            }

            var originalGO = collider2D.gameObject;
            var originalTransform = collider2D.gameObject.transform;
            
            for (int i = 0; i < numsplits; i++)
            {
                var ball = Instantiate(originalGO, originalTransform.position, originalTransform.rotation);
                
                Rigidbody2D ballrigidBody = ball.GetComponent<Rigidbody2D>();
                if(ballrigidBody != null)
                {
                    var strength = Random.Range(5, randomForceStrength);
                    strength *= RandomSign();

                    ballrigidBody.AddForce(new Vector2(1, 0) * strength);
                } 
            }

            Destroy(originalGO);
            Destroy(gameObject);
        }

        private int RandomSign () 
        {
            return Random.value < .5f? 1 : -1;
        }
    }
}

