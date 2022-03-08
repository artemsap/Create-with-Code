using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _speed = 10.0f;
    public float _horizontalBounds = 25.0f;
    public float _verticalBounds = 25.0f;
    public GameObject food;
    public KeyCode _shootButtom;

    private float _horizontalInput;
    private float _verticalInput;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > _horizontalBounds)
            transform.position = new Vector3(_horizontalBounds, transform.position.y, transform.position.z);
        if (transform.position.x < -_horizontalBounds)
            transform.position = new Vector3(-_horizontalBounds, transform.position.y, transform.position.z);
        if (transform.position.z > _verticalBounds)
            transform.position = new Vector3(transform.position.x, transform.position.y, _verticalBounds);
        if (transform.position.z < -_verticalBounds)
            transform.position = new Vector3(transform.position.x, transform.position.y, -_verticalBounds);

        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * _speed);

        _verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * _verticalInput * Time.deltaTime * _speed);

        if (Input.GetKeyDown(_shootButtom))
        {
            Instantiate(food, transform.position, food.transform.rotation);
        }

    }
}
