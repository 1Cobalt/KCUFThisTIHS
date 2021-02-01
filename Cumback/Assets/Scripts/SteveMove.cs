using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveMove : MonoBehaviour
{
    public float speed;
    Rigidbody2D steve;
    // Start is called before the first frame update
    void Start()
    {
        steve = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            steve.velocity = new Vector2( 0.5f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            steve.velocity = new Vector2(- 0.5f, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            steve.velocity = new Vector2(0, 4);

    }
}
