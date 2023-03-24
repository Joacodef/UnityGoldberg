using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRocket : MonoBehaviour
{
    public bool collided = false;
    float counter = 0;
    public int sleepTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter+=Time.deltaTime;
        if (collided == true &&  GameObject.Find("ammo_rocket"))
        {
            GameObject.Find("Button").GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            if (counter>sleepTime){
                GameObject.Find("ammo_rocket").transform.Translate(Vector3.forward * 10 * Time.deltaTime);
            }
        }       
    }


    void OnCollisionEnter(Collision collision)
    {
        collided = true;
    }
}
