using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    GameObject door;

    private void Start() 
    {
        door = GameObject.Find("Exit");    
    }

    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("TÜR");
        MoveDoor(); //When the player approaches the function is called.
    }
    void MoveDoor()
    {        
        door.transform.Translate(0,0,-6);
    }
}
