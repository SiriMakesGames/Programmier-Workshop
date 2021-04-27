using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitOnTriggerEnterNew : MonoBehaviour
{
    public int numBalls = 2;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.layer != 8){
            return;
        }

        for (int i = 0; i < numBalls; i++)
        {
            GameObject ball = Instantiate(collider2D.gameObject);
        }
    }
}
