using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float TimeBetweenSpawning = 1;

    private float timer = 0.0f;
    private bool pressed = false;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !pressed)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            pressed = true;
        }

        if (pressed)
            timer += Time.deltaTime;

        if (timer > TimeBetweenSpawning)
        {
            timer = 0;
            pressed = false;
        }
    }
}
