using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float fallDelay = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<RigidBody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareName("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb2d.isKinematic = false;

        yield return 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
