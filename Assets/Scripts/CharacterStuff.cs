using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStuff : MonoBehaviour
{
    //Create a float to use as a multiplier
    public float movementSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //create a new vector3 to funnel our axis input into
        //note that we use the horizontal axis for x, but the vertical axis for z, because w should move forward, not up
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0f, Input.GetAxis("Vertical"));

        //we use the setfloat method to change the parameter "Movement" based on the z value we are storing
        GetComponent<Animator>().SetFloat("Movement", move.z);

        //we can use the move function to take our vector3 storing our axis input and move by that amount with our multiplier so we can change it in the inspector
        GetComponent<CharacterController>().Move(move * movementSpeed);

/*      
        //Old uncool way of doing things
        if (Input.GetKey(KeyCode.W)){
            GetComponent<Animator>().SetFloat("Movement", 1f);
        } else {
            GetComponent<Animator>().SetFloat("Movement", 0f);
        }
        */
    }
}
