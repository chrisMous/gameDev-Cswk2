using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAction : MonoBehaviour
{
    public Interaction dialogue;
    public AdditionalDialogue additionalDialogue;

    public void TriggerDialogue() {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void TriggerAdditionalDialogue() {
        FindObjectOfType<DialogueManager>().LoadMoreDialogue(additionalDialogue);
    }
}

