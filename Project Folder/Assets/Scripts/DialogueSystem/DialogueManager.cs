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
        
        if(nameText.text.CompareTo("River Manager") == 0 && RiverQuest.extraDialogue == false){
            state = 2;
        }
        else if( RiverQuest.extraDialogue == true){
            state = 1;
        }

        if(nameText.text.CompareTo("Customer") == 0 || nameText.text.CompareTo("Customer Order 1") == 0 || 
        nameText.text.CompareTo("Bar  Manager") == 0 || nameText.text.CompareTo("Customer Order 2") == 0 ||
        nameText.text.CompareTo("Teacher") == 0 || (nameText.text.CompareTo("Student") == 0 && StudentQuest.complete) 
         || (nameText.text.CompareTo("PeopleArguing") == 0 && ConflictQuest.resolvedConflict)){
            state = 2;
        }

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
        Debug.Log(sentences.Count);
        if(sentences.Count == 0 && nameText.text.CompareTo("Friend") == 0){
            Destroy(GameObject.Find("Player").GetComponent<NPCManager>());
            Destroy(GameObject.Find("Player").GetComponent<DialogueManager>());
            EndDialogue();
            return;
        }
        
        else if ((sentences.Count == 0 && state == 1)) {
            Debug.Log("Showing choices!");
            buttonText();
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
        choiceCanvas.GetComponent<CanvasGroup>().interactable = false;
        choiceCanvas.GetComponent<CanvasGroup>().alpha = 0;
        animator.SetBool("isOpen", false);

        if(nameText.text.CompareTo("Mother Pig") == 0){
         Debug.Log("Back to Town");
         SceneManager.LoadScene("Town");
         }
         else if(nameText.text.CompareTo("River  Manager") == 0){
         Debug.Log("Back to Town");
         SceneManager.LoadScene("Town");
         }
         else if(nameText.text.CompareTo("Student") == 0 && StudentQuest.complete){
         Debug.Log("Back to Town");
         SceneManager.LoadScene("Town");
         }
         else if(nameText.text.CompareTo("People Arguing") == 0 && ConflictQuest.resolvedConflict){
         Debug.Log("Back to Town");
         SceneManager.LoadScene("Town");
         }
         else{
         nameText.text = "";
         }
    }

    public void buttonText(){
        if(nameText.text.CompareTo("Inn Chef") == 0){
        GameObject.Find("Choice1").GetComponentInChildren<Text>().text = "Sure I will get you the mushrooms";
        GameObject.Find("Choice2").GetComponentInChildren<Text>().text = "I will come back later";
        }
        else if(nameText.text.CompareTo("Student") == 0){
         if(StudentQuest.questionNumber == 1){
            GameObject.Find("Choice1").GetComponentInChildren<Text>().text = "5";
            GameObject.Find("Choice2").GetComponentInChildren<Text>().text = "6";
            }
            else if(StudentQuest.questionNumber == 2){
            GameObject.Find("Choice1").GetComponentInChildren<Text>().text = "Hampshire";
            GameObject.Find("Choice2").GetComponentInChildren<Text>().text = "Kent";
            
            }
            else if(StudentQuest.questionNumber == 3){
            
            GameObject.Find("Choice1").GetComponentInChildren<Text>().text = "Money";
            GameObject.Find("Choice2").GetComponentInChildren<Text>().text = "Friends";
            }
        }
        else if(nameText.text.CompareTo("People Arguing") == 0 && ConflictQuest.questionNo > 0){
             GameObject.Find("Choice3").GetComponentInChildren<Text>().text = "Rock";
             GameObject.Find("Choice1").GetComponentInChildren<Text>().text = "Paper";
             GameObject.Find("Choice2").GetComponentInChildren<Text>().text = "Scissors";
        }
    }
    public void loadScene(){
         if(nameText.text.CompareTo("Inn Chef") == 0){
         SceneManager.LoadScene("MushroomForest");
         }
         else if(nameText.text.CompareTo("Mother Pig") == 0){
         SceneManager.LoadScene("Town");
         }
         else if(nameText.text.CompareTo("Bar Manager") == 0){
         Debug.Log("Back to Town");
         SceneManager.LoadScene("Town");
         }
         else{
            Debug.Log("Back to Town");
            SceneManager.LoadScene("Town");
         }
    }

}