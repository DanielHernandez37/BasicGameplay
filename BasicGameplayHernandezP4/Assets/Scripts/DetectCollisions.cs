using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
 
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Player")
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
        if (gameObject.tag == "Food")
        {
            Score.score++;
            Debug.Log("Animal fed: " + Score.score);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}