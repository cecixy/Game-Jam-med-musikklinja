using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController1 : MonoBehaviour
{

    private Vector3 velocity = Vector3.zero;
    public float speed = 10.0F;

    private Rigidbody rb;


    void Start()
    {
		rb = GetComponent<Rigidbody> (); 
    }

    void FixedUpdate()
    {
        PerformMovement();

        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

    }

    void PerformMovement()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);              //"MovePosition different from transform.Translate because this will stop the Rigidbody from moving there if it collides with something on the way. Easier to control than the AddForce method
        }
    }
}
