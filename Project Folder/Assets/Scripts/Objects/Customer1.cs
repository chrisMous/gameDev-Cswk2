using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer1 : NPCAction
{
    private bool canBeRead = false;
    // Update is called once per frame
    void Update()
    {   
        if(canBeRead && Input.GetKeyDown(KeyCode.E) && InnQuest.hasDrink2){
            ApplicationHandler.decreaseF();
            GameObject.Find("WrongDrink").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(canBeRead && Input.GetKeyDown(KeyCode.E) && InnQuest.completed1){
             GameObject.Find("Player").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(canBeRead && Input.GetKeyDown(KeyCode.E) && !InnQuest.completed1 && InnQuest.hasDrink1){
            InnQuest.completedFirst();
            GameObject.Find("Drink1Audio").GetComponent<NPCManager>().TriggerDialogue();
            InnQuest.hasDrink1 = false;
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
