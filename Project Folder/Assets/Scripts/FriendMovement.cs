using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendMovement : MonoBehaviour
{
    private Animator animator;
    private float speed=5f;
    private float distance;
    private bool started = false;
    private float seconds = 2f;
    [SerializeField] private Transform player;

    void Start(){
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.position);
        if(distance>1f){
            chase();
        }
    }
    
    public void chase(){
        
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
