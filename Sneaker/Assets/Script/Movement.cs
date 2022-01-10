using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float fieldSizeX = 15f;
    [SerializeField] float fieldSizeZ = 4f;
    [SerializeField] InputAction input;



    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
    }

     void OnEnable() 
    {
        input.Enable();
    }

    void OnDisable() 
    {
        input.Disable();

    }

    void ProcessMovement()
    {   float xPos  = input.ReadValue<Vector2>().y;
        float zPos  = -input.ReadValue<Vector2>().x; //Need the joystic y for the Unity Z axis.

        float xOffset = xPos * Time.deltaTime * speed;
        float zOffset = zPos * Time.deltaTime * speed;

        float rawXPos = transform.localPosition.x + xOffset;
        float rawZPos = transform.localPosition.z + zOffset;

        float newMovementX = Mathf.Clamp(rawXPos, -fieldSizeX, fieldSizeX); //Futor TODO Clamp the groundsize.
        float newMovementY = Mathf.Clamp(rawZPos, -fieldSizeZ, fieldSizeZ);

         transform.localPosition = new Vector3(rawXPos,transform.localPosition.y, rawZPos);
    }
}
