using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    public Animator animator;
    public GameObject dialogueCanvas;
    public GameObject choiceCanvas;
    private int state;

    // Start is called before the first frame update
    void Start() {
        this.sentences = new Queue<string>();
        state = 1;
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

    public void LoadMoreDialogue(AdditionalDialogue extraDialogue){
        state = 2;
        sentences.Clear();
        foreach (string sentence in extraDialogue.additionalSentences) {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        
        if (sentences.Count == 0 && state == 1) {
            Debug.Log("Showing choices!");
            choiceCanvas.GetComponent<CanvasGroup>().interactable = true;
            choiceCanvas.GetComponent<CanvasGroup>().alpha = 1;
            return;
        }
        else if(sentences.Count == 0 && state == 2){
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
        choiceCanvas.GetComponent<CanvasGroup>().interactable = false;
        choiceCanvas.GetComponent<CanvasGroup>().alpha = 0;
        animator.SetBool("isOpen", false);
    }

    public void loadScene(){
         SceneManager.LoadScene("Town");
    }

}