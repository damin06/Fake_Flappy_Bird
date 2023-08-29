using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform scoreZoon;
    Rigidbody2D rb;

    bool isCheck;

    private void OnEnable()
    {
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
            isCheck = true;
            ScoreManager.Instance.ScorePlus();
        }
    }
}
