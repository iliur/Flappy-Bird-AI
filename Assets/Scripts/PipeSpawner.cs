using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawnTimer;
    private float spawnTimerSaver;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimerSaver = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer < 0)
        {
            Instantiate(pipe, new Vector2(gameObject.transform.position.x, Random.Range(-8,8)), Quaternion.identity);
            spawnTimer = spawnTimerSaver;
        }

    }
}
