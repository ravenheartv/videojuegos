using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jumpSpeed;
    [SerializeField] float fallSpeed;
    [SerializeField] float friccion;
    [SerializeField] float acceleration;
    [SerializeField] float maxHorizontalVelocity = 5f;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.D))
        {

            movement.x += 1;

        }

        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= 1;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);

        }
        if (rb.velocity.y == maxHorizontalVelocity)
        {
            rb.velocity = new Vector2(maxHorizontalVelocity, rb.velocity.x);
        }


        rb.velocity += movement * acceleration * Time.deltaTime;

    }
   
}
