using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    //create a public (shows up in the inspector) Transform (class name) called hazard
    public Transform hazard;
    
    //declare an array of hazards instead so we can work smarter, not harder
    //we dont need to declare the number of positions like you did in GD105, because making it public..
    //...we can change the number in the inspector, which is very helpful
    public Transform[] hazards;

    AudioSource deadAudioPlayer;
    public AudioClip dadAudioClip;

    //declare a new Vector3 (stores 3D positions) called startPos
    //we will use it to store our initial position
    Vector3 startPos;

    void Start()
    {
        //use our initial transform.position for startPos
        //we do it in start since that runs before players start playing
        startPos = transform.position;

        //assign our audiosource using GetComponent<>() (the type of component goes in between <>)
        //this will assign it to the component of that name attached to the same gameobject as our script
        deadAudioPlayer = GetComponent<AudioSource>();
    }
    void Update()
    {

        //we create a new for loop
        //reminder that the three parts inside the parentheses are:
        //1. A declaration and initial value (we use an integer called i by convention, which will allow us to iterate through)
        //2. A condition for determining if the loop should run an additional time, if true, run again
        //3. An update to our variable ... by increasing it by one, we can count through each hazard in our array
        for (int i = 0;i < hazards.Length; i++){
            //this is the same as our previous example, except we are checking the array, using the square brackets with the position inside of them
            //the first time this runs, i will be 0, the second time itll be 1, etc.
            if (transform.position == hazards[i].position){
                //use our startPos we set inside start as our new position, resetting it back to the beginning
                transform.position = startPos;

                //AudioSource.PlayOneShot() takes 2 parameters and plays an audio clip once
                //first parameter is which audioclip to play
                //second parameter is volume as a decimal 0-1
                deadAudioPlayer.PlayOneShot(dadAudioClip, 0.9f);
            }
        }
        /*
        //if our transform.position (the position of the transform of whatever this is attached to) ...
        //...is the same as our hazards position, then do whats in the curly brackets
        if (transform.position == hazard.position){
            Debug.Log("HAZARD OUCH");
            //Destroy(gameObject); //demonstration of how to destroy the player piece
            
            //use our startPos we set inside start as our new position, resetting it back to the beginning
            transform.position = startPos;
        }
        */
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
