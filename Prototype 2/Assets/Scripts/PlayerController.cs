using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _speed = 10.0f;
    public float _bounds = 25.0f;
    public GameObject food;
    public KeyCode _shootButtom;

    private float _horizontalInput;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > _bounds)
            transform.position = new Vector3(_bounds, transform.position.y, transform.position.z);
        if (transform.position.x < -_bounds)
            transform.position = new Vector3(-_bounds, transform.position.y, transform.position.z);

        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * _speed);

        if (Input.GetKeyDown(_shootButtom))
        {
            Instantiate(food, transform.position, food.transform.rotation);
        }

    }
}
