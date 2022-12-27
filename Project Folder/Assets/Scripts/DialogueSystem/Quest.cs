using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public int QuestId;
    public List<Target> Goals = new List<Target>();
    public string Name;
    public string Description;

    public void CheckGoals() {
        bool complete = true;
        foreach (Target goal in Goals) {
            if (!goal.Completed) {
                complete = false;
            }
        }
        if (complete) {
            Complete();
        }
    }

    public void Complete() {
        Debug.Log("Quest " + Name + " completed!");
        GameEvents.current.QuestCompleted(QuestId);
    }

    private void OnDestroy() {
        foreach (Target goal in Goals) {
            goal.OnDestroy();
        }
    }
}
