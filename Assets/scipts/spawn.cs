using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject dogs;
    public GameObject rats;
    float nextSpawnRats = 0.0f;
    float nextSpawnDogs = 0.0f;

    void Start ()
    {
        for (int i = 0; i < 3; i++)
        {
            float RandomX = Random.Range(-6.3f, 6.3f);
            float RandomY = Random.Range(-4.19f, 4.19f);
            Instantiate(dogs, new Vector3(RandomX, RandomY,0),Quaternion.identity);
        }

	}

	void Update ()
    {
        if(Time.time > nextSpawnRats)
        {
            nextSpawnRats = Time.time + 2f;
            SpawnRats();
        }
        if(Time.time > nextSpawnDogs)
        {
            nextSpawnDogs = Time.time + 10f;
            SpawnDogs();
        }
	}

    void SpawnRats()
    {
        float RandomX = Random.Range(-6.3f, 6.3f);
        float RandomY = Random.Range(-4.19f, 4.19f);
        Instantiate(rats, new Vector3(RandomX, RandomY, 0), Quaternion.identity);
    }
    void SpawnDogs()
    {
        float RandomX = Random.Range(-6.3f, 6.3f);
        float RandomY = Random.Range(-4.19f, 4.19f);
        Instantiate(dogs, new Vector3(RandomX, RandomY, 0), Quaternion.identity);
    }
}
