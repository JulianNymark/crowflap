using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    // Start is called before the first frame update

    private float spawnTimer = 0f;
    private float spawnTimeDiff = 3f;

    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (shouldSpawn())
        {
            SpawnPipe();
        }
    }

    bool shouldSpawn()
    {
        if (Time.time >= spawnTimer)
        {
            spawnTimer = Time.time + spawnTimeDiff;
            return true;
        }
        return false;
    }

    void SpawnPipe()
    {
        var position = new Vector3(10, 0, 0);
        var spawn = GameObject.Instantiate(pipePrefab, position, new Quaternion());

        float gap_y = (Random.value * 10f) - 5f;
        float gap_size = 2 + (Random.value * 3f);

        var spawnScript = spawn.GetComponent<PipeController>();
        spawnScript.Init(gap_y, gap_size);
    }
}
