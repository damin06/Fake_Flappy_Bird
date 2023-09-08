using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("SOName")]
    [SerializeField] private string enemySOName;

    protected float hp;
    protected float speed;
    protected float attack;
    protected float attackDelay;
    protected float range;

    protected virtual void OnEnable()//���� or Pop�ÿ� �ɷ�ġ �ʱ�ȭ
    {
        AgentData enemyData = Resources.Load<AgentData>($"EnemySO/{enemySOName}");
        enemyData = new AgentData(out hp, out attack, out speed, out attackDelay, out range);
    }

    protected virtual void Die()
    {
        WaveSystem.Instance.DieEnemy();
    }
}
