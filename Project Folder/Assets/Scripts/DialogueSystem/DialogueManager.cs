using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    public Animator animator;
    public GameObject dialogueCanvas;
    // Start is called before the first frame update
    void Start() {
        this.sentences = new Queue<string>();
    }

    public void StartDialogue(Interaction dialogue) {
        //StopAllCoroutines();
        dialogueCanvas.GetComponent<CanvasGroup>().alpha = 1;
        Debug.Log("Starting Convo: " + dialogue.name);
        sentences.Clear();
        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }
        nameText.text = dialogue.name;
        DisplayNextSentence();
        animator.SetBool("isOpen", true);
    }

    public void DisplayNextSentence() {
        
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence) {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()) {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void EndDialogue() {
        dialogueText.text = "";
        nameText.text = "";
        animator.SetBool("isOpen", false);
    }

}