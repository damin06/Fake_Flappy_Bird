using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action OnJump;
    public event Action OnDead;

    bool isDead;

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
            OnDead?.Invoke();
            Time.timeScale = 0;//데드이벤트 잘 넣으면 지울거임
        }
    }
}
