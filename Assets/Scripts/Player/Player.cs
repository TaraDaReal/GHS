using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 velocity;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Vector2.zero;
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.y = Input.GetAxisRaw("Vertical");
        velocity = Vector2.ClampMagnitude(velocity, 1f);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * moveSpeed * Time.fixedDeltaTime);
    }
}
