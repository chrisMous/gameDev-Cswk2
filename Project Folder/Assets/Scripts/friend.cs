using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friend : MonoBehaviour
{
    //public ScoreScript scoreVal;
    private bool canBeCollected = false;
    private bool collected = false;
    private FriendMovement movement;
    //[SerializeField] private AudioSource ceramicSoundEffect;
    //[SerializeField] private AudioSource coinSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player" && !canBeCollected) {
            canBeCollected = true;
        }
    }
    public void Start(){
        movement = GetComponent<FriendMovement>();
        Debug.Log("got component");
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player") && canBeCollected) {
            canBeCollected = false;
        }
    }

    public void Update() {
        if (!collected && canBeCollected && Input.GetKeyDown(KeyCode.E)) {
            //GetComponent<NPCManager>().TriggerDialogue(); // here will be the dialogue
            // Friend: Hey Friend, I came to visit because I saw a gathering in town
            // Me: Let's go
            ApplicationHandler.setFriendActive(true);
            movement.enabled = true;
        Debug.Log("enabled movement");

            
            
        }
    }
}
