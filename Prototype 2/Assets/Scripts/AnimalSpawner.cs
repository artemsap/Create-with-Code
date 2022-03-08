using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{

    public GameObject[] animals;
    [Range(1, 25)]
    public float _randomDistance = 30.0f;
    [Range(1,1000)]
    public int _speedSpawn = 100;

    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > (float)100.0f/_speedSpawn)
        {
            timer = 0;
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        int randomAnimal = Random.Range(0, animals.Length);
        float offset = Random.Range(-_randomDistance, _randomDistance);
        Instantiate(animals[randomAnimal], 
                    new Vector3(transform.position.x + offset, transform.position.y, transform.position.z), 
                    animals[randomAnimal].transform.rotation);
    }
}
