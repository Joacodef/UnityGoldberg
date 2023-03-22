using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMachine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the player presses the space bar, the game object named "Start" will be destroyed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(GameObject.Find("Start"));
        }        
    }
}
