using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    //public ScoreScript scoreVal;
    private bool canBeCollected = false;
    private bool collected = false;
    public string gem; 
    //[SerializeField] private AudioSource ceramicSoundEffect;
    //[SerializeField] private AudioSource coinSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player" && !canBeCollected) {
            canBeCollected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player") && canBeCollected) {
            canBeCollected = false;
        }
    }

    public void Update() {
        if (!collected && canBeCollected && Input.GetKeyDown(KeyCode.E)) {
            //collected = true;
            GetComponent<NPCManager>().TriggerDialogue();
            //ceramicSoundEffect.Play();
            //coinSoundEffect.Play();
            //scoreVal.decrementScore();
            //Debug.Log("Mushroom Collected");
            //ChestQuest.updateNum(gem);
        }
    }
    public void disappear(){
            StartCoroutine(Delete());
    }

    IEnumerator Delete() {
        yield return new WaitForSecondsRealtime(0.5f);
        Destroy(gameObject);
    }
}