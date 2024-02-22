using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
       playerDirection = new Vector2(0, directionY).normalized; 

        if(playerDirection != Vector2.zero)
        {
           animator.SetFloat("YInput", playerDirection.y);
        }


    }

        void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed); 

    }
}
