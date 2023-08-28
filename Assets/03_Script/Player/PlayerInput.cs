using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action OnJump;
    public event Action OnDead;

    private void Update()
    {
        EventInvoke();
    }

    void EventInvoke()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJump?.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.transform.tag == "Ground" || obj.transform.tag == "Pipe")
        {
            OnDead?.Invoke();
        }
    }
}
