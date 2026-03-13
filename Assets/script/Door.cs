using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Door : MonoBehaviour
{
    public NavMeshObstacle obsracle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CloseDoor()
    {
        obsracle.enabled = true;//通行不可
    }

    public void OpenDoor()
    {
        obsracle.enabled = false;//通行可能
    }
}
