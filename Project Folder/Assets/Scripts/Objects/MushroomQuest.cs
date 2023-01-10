using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomQuest : MonoBehaviour
{
    public static bool completeQuest;
    public static bool killedPig;
    public static int noCollected;
    public static bool speakAgain;
    void Start()
    {
        killedPig = false;
        completeQuest = false;
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
        ApplicationHandler.IncreaseQ();
    }
  }
  public void pigsDisappear(){
    killedPig = true;
    completeQuest = true;
    ApplicationHandler.decreaseF();
    GameObject.Find("Pigs").transform.localScale = new Vector3(0, 0, 0);
  }
}
