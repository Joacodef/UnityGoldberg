using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    int offset = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make the camera follow the player object (by using gameObject.find) in all directions, with an offset in all directions, and keep its angle fixed on the player object
        transform.position = new Vector3(9, GameObject.Find("Player").transform.position.y + offset, 0);
        transform.LookAt(GameObject.Find("Player").transform.position);     
    }
}
