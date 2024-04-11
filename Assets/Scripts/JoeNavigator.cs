using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //we need to add this directive at the top to gain access to the AI classes

public class JoeNavigator : MonoBehaviour
{

    NavMeshAgent joe; //creating a new agent in our script to manipulate
    public Transform target; //creating a transform to serve as the target for our agent

    // Start is called before the first frame update
    void Start()
    {
        //assign joe to the navmeshagent attached to the same gameobject
        joe = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //we set the destination to take the position of the target we set in the inspector
        joe.destination = target.position;
    }
}
