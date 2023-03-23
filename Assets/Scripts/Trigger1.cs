using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private Animator myAnimationController2;

    private void OnTriggerEnter(Collider other)
    { 
        // If the player enters the trigger, start the animations with the boolean "playRotacion" set to true
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Iniciar Rotacion");
            myAnimationController.SetBool("playRotacion",true);
            myAnimationController2.SetBool("playRotacion",true);
        }
    }
    /*
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Terminar Rotacion");
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("playRotacion",false);
            myAnimationController2.SetBool("playRotacion",false);
        }

    }*/

}
