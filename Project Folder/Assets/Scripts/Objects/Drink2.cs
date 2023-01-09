using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink2 : MonoBehaviour
{
  private bool canBeCollected = false;
  private bool collected = false;

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
            collected = true;
            Debug.Log("Drink2 Collected");
            InnQuest.getDrink2();
            GameObject.Find("Drink2").transform.localScale = new Vector3(0, 0, 0);
            return;
        }
    }

}
