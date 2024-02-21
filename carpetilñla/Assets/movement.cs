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
        Vector2 movementInput = Vector2.zero;

        if (Input.GetKey(KeyCode.D))
        {

            movementInput.x += 1;

        }

        if (Input.GetKey(KeyCode.A))
        {
            movementInput.x -= 1;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);

        }
        if(Mathf.Abs(rb.velocity.x) > maxHorizontalVelocity)
        {
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -maxHorizontalVelocity, maxHorizontalVelocity) , rb.velocity.y);
        }
        else
       


        rb.velocity += movementInput * acceleration * Time.deltaTime;

    }
   
}