
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player"){
            Destroy(gameObject);
            }

        Debug.Log("Esta Colisionando");
    }

    
}
