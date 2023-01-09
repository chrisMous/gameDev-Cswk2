using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider quests;
    public Slider friendship;

    
    public void setFriend(int amount){
        friendship.value = amount;
    }
    public void setQuests(int amount){
        quests.value = amount;
    }
}
