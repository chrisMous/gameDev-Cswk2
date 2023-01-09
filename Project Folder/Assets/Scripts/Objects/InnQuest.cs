using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnQuest : MonoBehaviour
{
    public static bool hasDrink1;
    public static bool hasDrink2;

    public static bool completed1;
    public static bool completed2;
    public static bool questDone;
 
    void Start()
    {
        hasDrink1 = false;
        hasDrink2 = false;
        completed1 = false;
        completed2 = false;
        questDone = false;
   
    }
    public static void getDrink1(){
        hasDrink1 = true;
        hasDrink2 = false;
    }
  
    public static void getDrink2(){
        hasDrink2 = true;
        hasDrink1 = false;
    }
    public static void completedFirst(){
         Debug.Log("Completed First");
         completed1 = true;
         completedQuest();
         
    }
    public static void completedSecond(){
        completed2 = true;
        completedQuest();
        
    }
    public static void completedQuest(){
        if(completed1 && completed2){
            Debug.Log("Completed Quest");
            questDone = true;
            GameObject.Find("QuestComplete").GetComponent<NPCManager>().TriggerDialogue();
        }
    }
}
