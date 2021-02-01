using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedMove : MonoBehaviour
{
    float Ymove;
    public float speed;
    private Rigidbody2D fizika;
    // Start is called before the first frame update
    void Start()
    {
        fizika = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float Xmove= Input.GetAxis("Horizontal");
        
        Vector2 movement = new Vector2(Xmove, Ymove);
        fizika.AddForce(movement * speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       Ymove = Input.GetAxis("Vertical");

    }
}

