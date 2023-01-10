using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestQuest : MonoBehaviour
{
    public static bool completedTreasurer;
    public static bool speakAgain;
    void Start()
    {
        completedTreasurer = false;
        speakAgain = false;
    }
    public static void completeQuest(){
      completedTreasurer = true;
      ApplicationHandler.IncreaseQ();
    }
}
