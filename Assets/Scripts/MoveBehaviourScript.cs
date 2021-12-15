using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviourScript : MonoBehaviour
{
    public float moveVelocityX;
    public float moveVelocityY;

    private Rigidbody2D rigidBody;    

    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float moveInputX = Input.GetAxis("Horizontal");
        float moveInputY = Input.GetAxis("Vertical");

        if (moveInputX > 0)
        {
            rigidBody.AddForce(new Vector2(+moveVelocityX, 0f));
        }
        else if (moveInputX < 0)
        {
            rigidBody.AddForce(new Vector2(-moveVelocityX, 0f));
        }
        else
        {
            rigidBody.velocity = Vector2.zero;
            rigidBody.angularVelocity = 0;
        }
    }

    private void FixedUpdate()
    {
        
    }
}
