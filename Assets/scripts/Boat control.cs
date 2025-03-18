using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boatcontrol : MonoBehaviour
{
    public float speed = 10f;
    private float Hdirection;
    private float Vdirection;
    private Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Hdirection = Input.GetAxis("Horizontal");
        Vdirection = Input.GetAxis("Vertical");

        Move();
        RotateBoat();
    }

    void Move()
    {
        rigidbody2D.velocity = new Vector2(Hdirection * speed, Vdirection * speed);
    }

    void RotateBoat()
    {
        Vector2 direction = rigidbody2D.velocity;
        if (direction.sqrMagnitude > 0.01f) // Avoid rotating when not moving
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90f; // Adjusted by -90 degrees
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}