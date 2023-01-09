using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestQuest : MonoBehaviour
{
    public static bool completedTreasurer;
    void Start()
    {
        completedTreasurer = false;
    }
    public static void completeQuest(){
      completedTreasurer = true;
    }
}
