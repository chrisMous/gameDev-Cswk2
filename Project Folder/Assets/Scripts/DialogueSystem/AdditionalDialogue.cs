using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AdditionalDialogue
{
    [TextArea(3, 10)]
    public string[] additionalSentences;

    public AdditionalDialogue(string[] sentences) {
        this.additionalSentences = sentences;
    }
}

