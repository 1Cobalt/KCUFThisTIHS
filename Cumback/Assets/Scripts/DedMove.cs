using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedMove : MonoBehaviour
{
<<<<<<< Updated upstream
    float Ymove;
    public float speed;
    private Rigidbody2D fizika;
    // Start is called before the first frame update
    void Start()
    {
        fizika = GetComponent<Rigidbody2D>();
=======
    private Rigidbody2D rb;//Rigidbody component
    private int jumpCheker;//is Grounded

    public float speed;//spid
    public float jumpForce;//Jump spid
    public int jumpCount;//jump kolichestvo

    public float fallMultiply = 2.5f;//magic 1
    public float lowJumpMultiply = 2.0f;//magic 2
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//Заполучение компонента
>>>>>>> Stashed changes
    }


    void Update()
    {
<<<<<<< Updated upstream
        
=======
        Move();
        Jump();
        MarioJump();
>>>>>>> Stashed changes
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

