using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform scoreZoon;

    AudioSource audioSource;
    Rigidbody2D rb;

    bool isCheck;

    private void OnEnable()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        isCheck = false;
    }

    private void Update()
    {
        MovePipe();
        CheckPlayer();
    }

    void MovePipe() => rb.velocity = Vector2.left * moveSpeed;

    void CheckPlayer()
    {
        if (Physics2D.OverlapBox(scoreZoon.position, Vector2.one, 0) && !isCheck)
        {
            audioSource.Play();
            isCheck = true;
            ScoreManager.Instance.ScorePlus();
        }
    }
}
