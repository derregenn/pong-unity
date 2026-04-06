using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movementVector;
    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementVector = new Vector2(0, Input.GetAxis("Vertical"));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.transform.position += (Vector3)movementVector * speed * Time.fixedDeltaTime;
    }
}