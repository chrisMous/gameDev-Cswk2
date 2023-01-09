using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 movement;
    private float speed;
    public float defaultSpeed = 5f;
    public static bool move = true;

    public void Start() {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        speed = defaultSpeed;
        
    }

    void Update() {
        if (move){
            movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        }
        
    }
    void FixedUpdate() {
        if(move){
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }
    }
}
