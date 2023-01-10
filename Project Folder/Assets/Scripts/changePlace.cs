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
            room = "StoryIntro";
        }
        else if (place == 2){
            room = "Town";
            if(ApplicationHandler.getQuests() >= 4){
                room = "StoryClimax";
            }
        }
        else if (place == 3){
            room = "Castle";
        }
        
        SceneManager.LoadScene(room);
    }
}
