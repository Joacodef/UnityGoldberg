using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    public bool collided = false;
    public bool move = false;
    public float speed = 10f;
    public float maxDistance = 5f;
    float initialYPosition;
    public float kickPower = 0.0001f;
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private Animator myAnimationController2;

    // Start is called before the first frame update
    void Start()
    {
        initialYPosition = transform.position.y;
        Debug.Log("Initial Y Position: " + initialYPosition);
    }

    // Update is called once per frame
    void Update()
    {
        // If collided is true, make the current verify if the object "Player" has a z coordinate higher than the current objects z coordinate
        if (collided)
        {
            if (GameObject.Find("Player").transform.position.z > transform.position.z)
            {
                move = true;
            }
            if (transform.position.y > maxDistance + initialYPosition)
            {
                move = false;
            }
            // If move is true, make the current object move up in the y axis
            if (move)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
                
                //Apply a force in the up direction to the player object  
                GameObject.Find("Player").GetComponent<Rigidbody>().AddForce(Vector3.up * kickPower, ForceMode.Impulse);
                
                myAnimationController.SetBool("playRotacion",true);
                myAnimationController2.SetBool("playRotacion",true);     
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
        //collided = false;
    }
}
