using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FlappyBird : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Vector2 Force;
    [SerializeField] private Vector2 Maximum_Velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Force);
        }
        if (rb.velocity.y <= Maximum_Velocity.y)
        {
            rb.velocity = Maximum_Velocity;
        }
       if(rb.velocity.y>=-1*Maximum_Velocity.y)
       {
            rb.velocity =-1*Maximum_Velocity;
       }
    }
}
