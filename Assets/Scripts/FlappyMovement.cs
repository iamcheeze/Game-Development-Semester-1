using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;

    public Vector3 upRotation;
    public Vector3 downRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            rb.velocity = Vector2.up * force;
            transform.rotation = Quaternion.Euler(upRotation);
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(downRotation), Time.deltaTime * 2);
    }
}
