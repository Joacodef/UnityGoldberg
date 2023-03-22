using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonMovement : MonoBehaviour
{
    public bool collided = false;
    public bool saltar = false;
    public float speed = 10f;
    public float maxDistance = 10f;
    float initialYPosition;
    public float kickPower = 0.0001f;

    // Start is called before the first frame update
    void Start()
    {
        initialYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // If collided is true, make the current verify if the object "Player" has a z coordinate higher than the current objects z coordinate
        if (collided)
        {
            if (GameObject.Find("Player").transform.position.z > transform.position.z)
            {
                saltar = true;
            }
            // If saltar is true, make the current object move up in the y axis
            if (saltar)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
                
                //Apply a force in the up direction to the player object  
                GameObject.Find("Player").GetComponent<Rigidbody>().AddForce(Vector3.up * kickPower, ForceMode.Impulse);

                // If the current object has moved up more than the distance variable, make saltar false
                if (transform.position.y > maxDistance + 40)
                {
                    saltar = false;
                }
            }
        }
    }

    // Se llama cuando el objeto entra en contacto con otro
    void OnCollisionEnter(Collision collision)
    {
        collided = true;
    }

    // Se llama cuando el objeto deja de entrar en contacto con otro
    void OnCollisionExit(Collision collision)
    {
        collided = false;
    }
}
