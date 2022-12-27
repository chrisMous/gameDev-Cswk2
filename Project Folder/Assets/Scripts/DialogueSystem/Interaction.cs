using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Interaction
{
   public string name;
    [TextArea(3, 10)]
    public string[] sentences;

    public Interaction(string[] sentences, string name) {
        this.sentences = sentences;
        this.name = name;
    }
}
