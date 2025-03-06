using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UIElements;

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

        MoveH();

        Vdirection = Input.GetAxis("Vertical");
        MoveV();

    }
    void MoveH()
    {
        rigidbody2D.velocity = new Vector2(Hdirection * speed, rigidbody2D.velocity.y);
    }
    void MoveV()
    {
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, Vdirection * speed);
    }
}
