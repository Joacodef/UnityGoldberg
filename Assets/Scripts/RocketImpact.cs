using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketImpact : MonoBehaviour
{
    public bool collided = false;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if (collided == true)
        {
            // The object named "Puerta" and the object named "ammo_rocket" are destroyed
            Destroy(GameObject.Find("Puerta"));
            Destroy(GameObject.Find("ammo_rocket"));
            collided = false;
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        // If the object collides with the object named "Puerta", set collided to true
        if (coll.gameObject.name == "Puerta"){
            collided = true;
        }   
    }
}
