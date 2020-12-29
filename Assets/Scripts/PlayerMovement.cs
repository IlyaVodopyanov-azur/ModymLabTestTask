using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed;
    public float speed;
    private float _timeDown;
    private float _timeUp;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _timeDown = Time.time;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _timeUp = Time.time;
            if (_timeUp - _timeDown > 0.5f)
            {
                rb.AddForce(0, 10000, 0);
                Debug.LogError("СИЛЬНЫЙ ПРЫЖОК");
            }
            if (_timeUp - _timeDown < 0.5f)
            {
                rb.AddForce(0, 1000, 0);
                Debug.LogError("СЛАБЫЙ ПРЫЖОК");
            }
        }

    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(speed, rb.velocity.y, speed);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
       rb.AddForce(movement);
    }
}
