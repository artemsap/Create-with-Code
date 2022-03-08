using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Down,
    Up,
    Left,
    Right
}

public class AnimalSpawner : MonoBehaviour
{

    public GameObject[] animals;
    [Range(1, 25)]
    public float _randomDistance = 30.0f;
    [Range(11,1000)]
    public int _speedSpawn = 100;

    public Direction _direction = Direction.Down;

    private float timer = 0;
    private Quaternion quat;

    private void Start()
    {
        switch(_direction)
        {
            case Direction.Down:
                quat = Quaternion.Euler(new Vector3(0, 180, 0));
                break;
            case Direction.Up:
                quat = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
            case Direction.Right:
                quat = Quaternion.Euler(new Vector3(0, 90, 0));
                break;
            case Direction.Left:
                quat = Quaternion.Euler(new Vector3(0, -90, 0));
                break;
        }
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > (float)100.0f/_speedSpawn)
        {
            _speedSpawn = Random.Range(_speedSpawn - 10, _speedSpawn + 10);
            timer = 0;
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        int randomAnimal = Random.Range(0, animals.Length);
        float offset = Random.Range(-_randomDistance, _randomDistance);

        switch (_direction)
        {
            case Direction.Down:
                Instantiate(animals[randomAnimal],
                new Vector3(transform.position.x + offset, transform.position.y, transform.position.z),
                quat);
                break;
            case Direction.Up:
                Instantiate(animals[randomAnimal],
                new Vector3(transform.position.x + offset, transform.position.y, transform.position.z),
                quat);
                break;
            case Direction.Right:
                Instantiate(animals[randomAnimal],
                new Vector3(transform.position.x, transform.position.y, transform.position.z + offset),
                quat);
                break;
            case Direction.Left:
                Instantiate(animals[randomAnimal],
                new Vector3(transform.position.x, transform.position.y, transform.position.z + offset),
                quat);
                break;
        }
    }
}
