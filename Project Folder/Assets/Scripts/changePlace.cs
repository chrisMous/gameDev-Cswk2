using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changePlace : MonoBehaviour
{
public int place;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
	{
        changeRoom();
    }

    void changeRoom(){
        string room = "Home" ;
        if (place == 1){
            room = "Town";
        }
        SceneManager.LoadScene(room);
    }
}