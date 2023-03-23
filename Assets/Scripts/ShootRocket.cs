using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRocket : MonoBehaviour
{
    public bool collided = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collided == true &&  GameObject.Find("ammo_rocket"))
        {
            GameObject.Find("ammo_rocket").transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }       
    }


    void OnCollisionEnter(Collision collision)
    {
        collided = true;
    }
}
