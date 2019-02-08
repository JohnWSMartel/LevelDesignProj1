using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMove : MonoBehaviour
{
    float moveSpeed = 3f;
    bool moveUp = true;
    public float pointA, pointB;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < pointA)
        {
            moveUp = true;
        } else if (transform.position.y > pointB)
        {
            moveUp = false;
        }

        if(moveUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, transform.position.z);
        } else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime, transform.position.z);
        }
    }
}
