using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverQuest : MonoBehaviour
{
    public static int blocked;
    public bool chooseHelp;
    void Start()
    {
        blocked = 0;
        chooseHelp = false;
    }
    public static void incrementBlocked(){
        blocked++;
        Debug.Log("Blocked: " + blocked);
        GameObject.Find("rock").GetComponent<NPCManager>().TriggerDialogue();
        if(blocked == 2){
            Debug.Log("Successfully Blocked");
            GameObject.Find("Player").GetComponent<NPCManager>().TriggerDialogue();
        }
    }

    public static void decrementBlocked(){
        blocked--;
    }

   
}
