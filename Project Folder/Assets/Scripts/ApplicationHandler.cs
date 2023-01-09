using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ApplicationHandler : MonoBehaviour
{
    private static int quests = 0;
    private static int friendShipLevel = 6;
    private static int state = 0;
    private static HealthBar friendship;
    private static string gem = "no";
    private static int shrooms = 0;

    // Start is called before the first frame update
    void Start()
    {
        friendship = GetComponent<HealthBar>();
        
    }

    // Update is called once per frame
    
    void Update()
    {
        friendship.setFriend(friendShipLevel);
        
    }
    public static void setFriendActive(bool value){
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Find("healthbar").gameObject.SetActive(value);
    }
    public static int getShrooms(){
        return shrooms;
    }
    public static void setShrooms(int value){
        shrooms = value;
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
    }
}
