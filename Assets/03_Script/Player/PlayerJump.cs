using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float rotSpeed;

    AudioSource audioSource;
    Rigidbody2D rb;
    PlayerInput input;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();

        input = GetComponent<PlayerInput>();
        input.OnJump += Jump;
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotSpeed + 20f);
    }

    void Jump()
    {
        audioSource.Play();
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
    }
}
