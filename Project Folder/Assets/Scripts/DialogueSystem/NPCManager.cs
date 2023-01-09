using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : NPCAction
{
   private bool canBeRead = false;
   //public QuestGiver questGiver;


    // Update is called once per frame
    void Update()
    {
        if (canBeRead && Input.GetKeyDown(KeyCode.E)) {
            TriggerDialogue();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            canBeRead = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "Player") {
            canBeRead = false;
        }
    }
}
