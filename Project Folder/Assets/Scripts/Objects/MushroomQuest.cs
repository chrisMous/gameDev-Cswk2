using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomQuest : MonoBehaviour
{
    public static int noCollected;
    void Start()
    {
        noCollected = 0;
        GameObject.Find("Pigs").transform.localScale = new Vector3(0, 0, 0);
    }

  public static void updateNum(){
    noCollected++;
    Debug.Log(noCollected);
    if(noCollected == 5){
        Debug.Log("All Collected");
        GameObject.Find("Pigs").transform.localScale = new Vector3(1, 1, 1);
        GameObject.Find("Player").GetComponent<NPCManager>().TriggerDialogue();
    }
  }
  public void pigsDisappear(){
    GameObject.Find("Pigs").transform.localScale = new Vector3(0, 0, 0);
  }
}
