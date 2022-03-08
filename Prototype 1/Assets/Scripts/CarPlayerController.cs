using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPlayerController : MonoBehaviour
{
    [SerializeField] private float Speed = 20.0f;
    [SerializeField] private float TurnSpeed = 40.0f; 
    private float horizontalInput;
    private float forwatdInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string ID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + ID);
        forwatdInput = Input.GetAxis("Vertical" + ID);

        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwatdInput);
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
