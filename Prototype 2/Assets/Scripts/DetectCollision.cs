using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    static public int Health = 5;
    static private int Score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("DestroyCollider"))
        {
            Debug.Log($"Health = {--Health}\n");
            Destroy(gameObject);

            if (Health < 0)
                Debug.Log("Game Over");
        }
        else
        {
            Debug.Log($"Score = {++Score}\n");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
