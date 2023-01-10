using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentQuest : MonoBehaviour
{
    public static bool complete;
    public static int questionNumber;
    void Start()
    {
        complete = false;
        questionNumber = 1;
    }

    public static void updateNumber(){
        questionNumber++;
    }
    public static void completeQuest(){
        complete = true;
    }
    public static void handleButton1(){
        questionNumber++;
        if(questionNumber == 2){
            GameObject.Find("Question2").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(questionNumber == 3){
            GameObject.Find("Question3").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(questionNumber == 4){
            ApplicationHandler.decreaseF();
            GameObject.Find("MoneyChoice").GetComponent<NPCManager>().TriggerDialogue();
            completeQuest();
        }
    }
    public static void handleButton2(){
        questionNumber++;
        if(questionNumber == 2){
            GameObject.Find("Question2").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(questionNumber == 3){
            GameObject.Find("Question3").GetComponent<NPCManager>().TriggerDialogue();
        }
        else if(questionNumber == 4){
            ApplicationHandler.IncreaseF();
            GameObject.Find("FriendChoice").GetComponent<NPCManager>().TriggerDialogue();
            completeQuest();
        }
    }
}
