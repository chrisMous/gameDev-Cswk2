using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestQuest : MonoBehaviour
{
    public static int noCollected;
    void Start()
    {
        
    }

  public static void updateNum(string gem){
  
    Debug.Log("Collected a gem");
    if(gem == "gold"){
        Debug.Log("All good");
        //GameObject.Find("Pigs").transform.localScale = new Vector3(1, 1, 1);
        GameObject.Find("Player").GetComponent<NPCManager>().TriggerDialogue();
    }
  }
  // public void pigsDisappear(){
  //   GameObject.Find("Pigs").transform.localScale = new Vector3(0, 0, 0);
  // }
}
