using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Bullet : MonoBehaviour
{
    public float life = 3;
 
    void Awake()
    {
        Destroy(gameObject, life);
    }
 
    void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.name == "Player")
                {
                    GameManager.health -= 1;
                    Destroy(gameObject);
            
                }

                
    }
}