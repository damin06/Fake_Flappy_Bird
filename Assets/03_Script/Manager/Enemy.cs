using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private string enemySOName;

    private float hp;
    private float speed;
    private float attack;
    private float attackDelay;
    private float range;

    private void OnEnable()//���� or Pop�ÿ� �ɷ�ġ �ʱ�ȭ
    {
        EnemyData enemyData = Resources.Load<EnemyData>($"EnemySO/{enemySOName}");
        enemyData = new EnemyData(out hp, out attack, out speed, out attackDelay, out range);
    }
}
