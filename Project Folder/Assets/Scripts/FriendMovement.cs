using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendMovement : MonoBehaviour
{
    private Animator animator;
    private bool right = true;
    private float speed=5f;
    private float distance;
    private bool started = false;
    private float seconds = 2f;
    private Vector2 velo ;
    private SpriteRenderer sprite ;
    private Vector2 target;
    private Vector2 current;
    private Rigidbody2D rb;
    [SerializeField] private Transform player;

    void Start(){
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       target = new Vector2(player.position.x, player.position.y);
        current = new Vector2(transform.position.x, transform.position.y);
        Debug.Log(rb.velocity.x + " + "+ rb.velocity.y);
        velo =(target-current).normalized; // this has length 1
        distance = Vector2.Distance(transform.position, player.position);
        animator.SetFloat("Horizontal", rb.velocity.x);
        animator.SetFloat("Vertical", rb.velocity.y);
        if(rb.velocity.x >0f) {
            if (sprite.flipX){
                sprite.flipX = false;
            }
         }
         else if (rb.velocity.x <0f){

            sprite.flipX = true;
         }
        if(distance>1f){
            animator.SetBool("moving",true);
           chase();
       }
        else{
            rb.velocity = new Vector2(0,0);
            animator.SetBool("moving",false);
        }
    }
    
    public void chase(){
        rb.velocity = velo*speed;
        //rb.velocity = Vector2.MoveTowards(a, b, speed);
        //rb.velocity = Vector2.MoveTowards(transform.position, player.position, speed );
    }
}
