using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ChangeDirectionOnCollision : MonoBehaviour
{
    [SerializeField] private float minStrength = 0.1f;
    [SerializeField] private float maxStrength = 0.2f;
    private Rigidbody2D rigidBody2D;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidBody2D.AddRelativeForce(new Vector2(Random.Range(minStrength, maxStrength), Random.Range(minStrength, maxStrength)), ForceMode2D.Impulse);
    }
}
