using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerMovement : MonoBehaviour
{
    //create a new Rigidbody called rb to manipulate in our script
    Rigidbody rb;

    //make a new public variable to change our acceleration force
    public float acc = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //assign RB using GetComponent (the rigidbody attached to this gameobject)
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called once per standard interval instead of per frame
    void FixedUpdate()
    {
        //same as our previous script except using getkey since we want it to apply continuously if its being pressed down, not just for one frame
        if (Input.GetKey(KeyCode.W)){
            //we are using the AddForce method in the appropriate direction using our variable
            rb.AddForce(0f, 0f, acc);
        }
        if (Input.GetKey(KeyCode.S)){
            rb.AddForce(0f, 0f, -acc);
        }
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(-acc, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(acc, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.E)){
            rb.AddForce(0f, acc, 0f);
        }
        if (Input.GetKey(KeyCode.Q)){
            rb.AddForce(0f, -acc, 0f);
        }
    }
}
