using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer2 : NPCAction
{
   private bool canBeRead = false;
    // Update is called once per frame
    void Update()
    {   
        if(canBeRead && Input.GetKeyDown(KeyCode.E) && InnQuest.hasDrink1){
            ApplicationHandler.decreaseF();
            GameObject.Find("WrongDrink").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(canBeRead && Input.GetKeyDown(KeyCode.E) && InnQuest.completed2){
             GameObject.Find("Player").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(canBeRead && Input.GetKeyDown(KeyCode.E) && !InnQuest.completed2 && InnQuest.hasDrink2){
            InnQuest.completedSecond();
            GameObject.Find("Drink1Audio").GetComponent<NPCManager>().TriggerDialogue();
            InnQuest.hasDrink2 = false;
        }
        else if(canBeRead && Input.GetKeyDown(KeyCode.E)) {
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
