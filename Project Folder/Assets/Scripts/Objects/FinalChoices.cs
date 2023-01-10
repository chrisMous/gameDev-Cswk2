using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalChoices : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool badEnding;
    public static int choiceNumber;
    void Start()
    {
        badEnding = false;
        choiceNumber = 1;
    }
    public static void firstChoice(){
        if(choiceNumber == 1 && ApplicationHandler.friendShipLevel < 3){
            badEnding = true;
            GameObject.Find("LowFriendship").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(choiceNumber == 1 && ApplicationHandler.friendShipLevel > 2){
            choiceNumber++;
            GameObject.Find("Thiefs").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("ThiefDialogue").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(choiceNumber > 1 && !badEnding){
            GameObject.Find("Win").GetComponent<CanvasGroup>().interactable = true;
            GameObject.Find("Win").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("CorrectChoice").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(badEnding){
                SceneManager.LoadScene("Menu");

        }
    }
    public static void secondChoice(){
         if(choiceNumber == 1){
            GameObject.Find("DialogueParent").GetComponent<DialogueManager>().EndDialogue();
        }
        else if(choiceNumber > 1){
            badEnding = true;
            GameObject.Find("BadChoice").GetComponent<NPCManager>().TriggerDialogue();
        }
         else if(badEnding){
            SceneManager.LoadScene("Menu");
        }
    }
    public void goToCastle(){
        GameObject.Find("Kings").transform.localScale = new Vector3(0, 0, 0);
        this.GetComponent<PlayerMovement>().leadToCastle();
    }
}
