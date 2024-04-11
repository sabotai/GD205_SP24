using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //we need to add this directive at the top to gain access to the AI classes

public class BobShellyPlayerCharacter : MonoBehaviour
{

    NavMeshAgent bobShelly;
    Animator bobAnim;
    // Start is called before the first frame update
    void Start()
    {
        bobShelly = GetComponent<NavMeshAgent>();
        bobAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         //create a new Ray object called laser
        //and use the ScreenPointToRay method of cameras
        //which takes an argument of a vector3 corresponding to screen position
        //we used mousePosition from the input class
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        //raycasthit is a class that will store information for a raycast hitting something
        //we use the constructor (new RaycastHit()) to initialize it
        RaycastHit hit = new RaycastHit();

        //Physics.Raycast will cast our ray and return true if it hits a collider
        //if thats true and the left mouse button is pressed, then do the following
        if (Physics.Raycast(laser, out hit) && Input.GetMouseButton(0)){
            bobShelly.destination = hit.point;
        }

        if (bobShelly.remainingDistance > 1f){
            bobAnim.SetBool("Moving", true);
        } else {
            bobAnim.SetBool("Moving", false);
        }
    }
}
