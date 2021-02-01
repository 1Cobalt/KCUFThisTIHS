using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexMove : MonoBehaviour
{
    public float speed;
    Rigidbody2D alex;
    // Start is called before the first frame update
    void Start()
    {
        alex = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            alex.velocity = new Vector2(0.5f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            alex.velocity = new Vector2(-0.5f, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        alex.velocity = new Vector2(0, 4);

    }
}
