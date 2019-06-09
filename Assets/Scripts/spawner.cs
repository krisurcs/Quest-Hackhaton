using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] spawnObject;
    public GameObject[] spawnLocation;
    public AudioSource soundLoop;
    private float prevLoopTime = 0f;
    private GameObject currentSpawnObject;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject i in spawnLocation)
        {
            i.GetComponentInChildren<MeshRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //taimeris
        timer += Time.deltaTime;

        //if (timer > 60)
        //{ }
        if (soundLoop.time < prevLoopTime)
        {
            //if (currentSpawnObject != null) { Destroy(currentSpawnObject); }
            currentSpawnObject = SpawnNewSocket();
            timer = 0f;
            soundLoop.pitch += 0.05f;
        }
        prevLoopTime = soundLoop.time;
        print(timer);

    }
    GameObject SpawnNewSocket()
    {
        int type = Random.Range(0, 2);
        int loc = Random.Range(0, 23);
        var instance = Instantiate(spawnObject[type], spawnLocation[loc].transform.position, spawnLocation[loc].transform.rotation);
        return instance;
    }
}
