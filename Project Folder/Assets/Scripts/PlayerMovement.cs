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
        move = true;
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
    public void leadToCastle(){
        Debug.Log("going to castle");
        PlayerMovement.move = false;
        Transform exit = GameObject.Find("exit").GetComponent<Transform>();
        Vector2 target = new Vector2(exit.position.x, exit.position.y);
        Vector2 current = new Vector2(transform.position.x, transform.position.y);
        Vector2 velo =(target-current).normalized;
        StartCoroutine(movee(velo));

    }
     IEnumerator movee(Vector2 velo) {
        
        yield return new WaitForSeconds(1f);
        rb.velocity = velo*speed;
        Debug.Log(rb.velocity.y);
        animator.SetFloat("Vertical", rb.velocity.y);
        animator.SetFloat("Speed", 5f);
        Debug.Log(animator.GetFloat("Vertical"));
        
    
    }
}
