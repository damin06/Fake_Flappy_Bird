using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipeObj;
    [SerializeField] private float spawnTime;
    [SerializeField] private float heightRange;

    private Queue<GameObject> spawnPipe = new Queue<GameObject>();


    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject pipe = PoolingManager.instance.Pop(pipeObj.name, new Vector3(transform.position.x, transform.position.y + Random.Range(-heightRange, heightRange)));
            spawnPipe.Enqueue(pipe);
            yield return new WaitForSeconds(spawnTime);

            if (spawnPipe.Count > 4)
                PoolingManager.instance.Push(spawnPipe.Dequeue());
        }
    }
}
