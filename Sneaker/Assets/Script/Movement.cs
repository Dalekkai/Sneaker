using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    int speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
    }

    void ProcessMovement()
    {   float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");

        float xOffset = xThrow * Time.deltaTime * speed;
        float yOffset = yThrow * Time.deltaTime * speed;

        float rawXPos = transform.localPosition.x + xOffset;
        float rawZPos = transform.localPosition.z + yOffset;

         transform.localPosition = new Vector3(rawXPos,transform.localPosition.y, rawZPos);
    }
}
