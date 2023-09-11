using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action OnJump;
    public event Action<int> OnDead;
    private PlayEnd playEnd;

    bool isDead;

    private void Start()
    {
        playEnd = GetComponent<PlayEnd>();
        OnDead += playEnd.ChangeScene;
    }

    private void Update()
    {
        EventInvoke();
    }

    void EventInvoke()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            OnJump?.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (!isDead && (obj.transform.tag == "Ground" || obj.transform.tag == "Pipe"))
        {
            isDead = true;
            OnDead?.Invoke(2);
        }
    }
}
