using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlatformController : MonoBehaviour
{
    [SerializeField] private float speed = 500f;
    [SerializeField] private float threshold = .01f;
    private Rigidbody2D rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float translation = Input.GetAxisRaw("Horizontal");
        translation *= Time.deltaTime * speed;

        // Debug.Log($"translation {translation}");

        if(Mathf.Abs(translation) < threshold)
        {
            rigidBody.velocity = Vector2.zero;
        }
        else
        {
            rigidBody.AddForce(transform.right * translation);
        }
    }
}
