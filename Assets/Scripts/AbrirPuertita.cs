using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuertita : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
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
            GameObject.Find("Button (1)").GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            myAnimationController.SetBool("abrirPuertita",true);
        }       
    }


    void OnCollisionEnter(Collision collision)
    {
        collided = true;
    }
}
