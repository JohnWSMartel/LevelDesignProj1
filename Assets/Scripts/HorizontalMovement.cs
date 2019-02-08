using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    float moveSpeed = 3f;
    bool moveRight = false;
    public float pointA, pointB;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < pointA)
        {
            moveRight = true;
        }
        else if (transform.position.x > pointB)
        {
            moveRight = false;
        }

        if (moveRight)
        {
            transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
