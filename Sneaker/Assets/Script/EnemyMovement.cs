using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    [SerializeField] float movementFactor;

    [SerializeField] float period = 2f;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement() //Move using singwave. 
    {
        if (period== 0) return;
        
        float cycles = Time.time / period; // Growing over time.

        const float tau = Mathf.PI * 2; // Constant value of 6.283...

        float rawSinWave = Mathf.Sin(cycles * tau); // Going from -1 to 1

        movementFactor = (rawSinWave + 1f) * 2; // Changing the value to 0 to 1

        Vector3 offset = movementVector * movementFactor; 
        transform.position = startingPosition + offset;
    }
}
