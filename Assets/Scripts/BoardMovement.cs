using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    //create a public (shows up in the inspector) Transform (class name) called hazard
    public Transform hazard;

    //declare a new Vector3 (stores 3D positions) called startPos
    //we will use it to store our initial position
    Vector3 startPos;

    void Start()
    {
        //use our initial transform.position for startPos
        //we do it in start since that runs before players start playing
        startPos = transform.position;
    }
    void Update()
    {
        //if our transform.position (the position of the transform of whatever this is attached to) ...
        //...is the same as our hazards position, then do whats in the curly brackets
        if (transform.position == hazard.position){
            Debug.Log("HAZARD OUCH");
            //Destroy(gameObject); //demonstration of how to destroy the player piece
            
            //use our startPos we set inside start as our new position, resetting it back to the beginning
            transform.position = startPos;
        }
        if (Input.GetKeyDown(KeyCode.W)){
            Debug.Log("pressed the w key");
            transform.position += new Vector3(0f, 0f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.S)){
            Debug.Log("pressed the s key");
            transform.position += new Vector3(0f, 0f, -1f);
        }
        if (Input.GetKeyDown(KeyCode.A)){
            Debug.Log("pressed the a key");
            transform.position += new Vector3(-1f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D)){
            Debug.Log("pressed the d key");
            transform.position += new Vector3(1f, 0f, 0f);
        }
    }
}
