using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConflictQuest : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool resolvedConflict;
    public static int questionNo;
    public static bool speakAgain;
    void Start()
    {
        resolvedConflict = false;
        questionNo = 0;
        speakAgain = false;
    }

    public static void handleButton3(){
         if(questionNo == 0){
            SceneManager.LoadScene("Home");
        }
        else{
        int rock = 1;
        int npcChoice = Random.Range(1, 3);

        if(rock == npcChoice){
            GameObject.Find("PlayAgain1").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(npcChoice == 2){
            GameObject.Find("goHome").GetComponent<CanvasGroup>().interactable = true;
            GameObject.Find("goHome").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Loss1").GetComponent<NPCManager>().TriggerDialogue();
            ApplicationHandler.decreaseF();
            resolvedConflict = true;
            ApplicationHandler.IncreaseQ();
        } 
        else{
             GameObject.Find("goHome").GetComponent<CanvasGroup>().interactable = true;
             GameObject.Find("goHome").GetComponent<CanvasGroup>().alpha = 1;
             GameObject.Find("Win1").GetComponent<NPCManager>().TriggerDialogue();
             resolvedConflict = true;
             ApplicationHandler.IncreaseQ();
        }
        }
    
    }
    public static void handleButton1(){
        if(questionNo == 0){
            GameObject.Find("goHome").GetComponent<CanvasGroup>().interactable = true;
            GameObject.Find("goHome").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("npc1").GetComponent<NPCManager>().TriggerDialogue();
            ApplicationHandler.IncreaseF();
            resolvedConflict = true;
            ApplicationHandler.IncreaseQ();
        }
        else{
        int paper = 2;
        int npcChoice = Random.Range(1, 3);

        if(paper == npcChoice){
            GameObject.Find("PlayAgain2").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(npcChoice == 3){
            GameObject.Find("goHome").GetComponent<CanvasGroup>().interactable = true;
            GameObject.Find("goHome").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Loss2").GetComponent<NPCManager>().TriggerDialogue();
            ApplicationHandler.decreaseF();
            resolvedConflict = true;
            ApplicationHandler.IncreaseQ();
        }
        else{
             GameObject.Find("goHome").GetComponent<CanvasGroup>().interactable = true;
             GameObject.Find("goHome").GetComponent<CanvasGroup>().alpha = 1;
             GameObject.Find("Win2").GetComponent<NPCManager>().TriggerDialogue();
             resolvedConflict = true;
             ApplicationHandler.IncreaseQ();
        }
      }
    }
    public static void handleButton2(){
        if(questionNo == 0){
            questionNo++;
            GameObject.Find("PlayRPS").GetComponent<NPCManager>().TriggerDialogue();
        }
        else{
        int scissors = 3;
        int npcChoice = Random.Range(1, 3);

        if(scissors == npcChoice){
            GameObject.Find("PlayAgain3").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(npcChoice == 1){
            GameObject.Find("goHome").GetComponent<CanvasGroup>().interactable = true;
            GameObject.Find("goHome").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Loss3").GetComponent<NPCManager>().TriggerDialogue();
            ApplicationHandler.decreaseF();
            resolvedConflict = true;
            ApplicationHandler.IncreaseQ();
        }
        else{
             GameObject.Find("goHome").GetComponent<CanvasGroup>().interactable = true;
             GameObject.Find("goHome").GetComponent<CanvasGroup>().alpha = 1;
             GameObject.Find("Win3").GetComponent<NPCManager>().TriggerDialogue();
             resolvedConflict = true;
             ApplicationHandler.IncreaseQ();
        }
        }
    }
}
