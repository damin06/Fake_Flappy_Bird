using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;

    Rigidbody2D rb;
    PlayerInput input;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        input = GetComponent<PlayerInput>();
        input.OnJump += Jump;
    }

    void Jump()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
    }
}
