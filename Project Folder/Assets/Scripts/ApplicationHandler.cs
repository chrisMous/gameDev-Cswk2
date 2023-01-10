using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ApplicationHandler : MonoBehaviour
{
    private static int quests = 0;
    public static int friendShipLevel = 6;
    private static int state = 0;
    private static HealthBar friendship;
    private static HealthBar quest;
    private static string gem = "no";
    private static int shrooms = 0;

    // Start is called before the first frame update
    void Start()
    {
        friendship = GetComponent<HealthBar>();
        quest = GetComponent<HealthBar>();
    }

    // Update is called once per frame
    
    void Update()
    {
        friendship.setFriend(friendShipLevel);
        quest.setQuests(quests);
    }
    public static void setFriendActive(bool value){
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Find("healthbar").gameObject.SetActive(value);
    }
    public static void setQuestsActive(bool value){
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Find("Quests").gameObject.SetActive(value);
    }
    public static int getShrooms(){
        return shrooms;
    }
    public static void setShrooms(int value){
        shrooms = value;
    }
    public static int getQuests(){
        return quests;
    }
    public static void setQuests(int value){
        quests = value;
    }
    public static int getFriendship(){
        return friendShipLevel;
    }
    public static void setFriendShip(int value){
        friendShipLevel = value;
    }

    public static string getGem(){
        return gem;
    }
    public static void setGem(string value){
        gem = value;
    }

    public static void decreaseF(){
        Debug.Log("Decrease");
        if (friendShipLevel>=1)
        friendShipLevel = friendShipLevel-1;
    }
    public static void IncreaseF(){
        Debug.Log("Increase");
        if(friendShipLevel<=5)
            friendShipLevel = friendShipLevel+1;
    }

    public static void reset(){
        friendShipLevel = 6;
        quests = 0;
        state = 0;
        //reset everything
        SceneManager.LoadScene("Start");
    }
    public static void quit(){
        SceneManager.LoadScene("menu");
    }
    public static void decreaseQ(){
        Debug.Log("Decrease");
        if (quests>=1)
        quests = quests-1;
    }
    public static void IncreaseQ(){
        Debug.Log("Increase");
        if(quests<=3)
            quests = quests+1;
    }

}
