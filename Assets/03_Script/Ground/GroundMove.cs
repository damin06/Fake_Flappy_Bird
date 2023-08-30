using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveX;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = Vector2.left * moveSpeed;

        if (transform.position.x <= -moveX)
            transform.position = new Vector3(moveX, transform.position.y, 0);
    }
}
