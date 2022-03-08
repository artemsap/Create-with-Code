using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AnimalDestroyer")
            Debug.Log("Game Over");
        Destroy(gameObject);
    }
}
