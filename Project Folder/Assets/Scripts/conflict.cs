using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conflict : MonoBehaviour
{
    public void string[] text; 
    // Start is called before the first frame update
    void Start()
    {
        preText = ["NPC: Please Hurry! My neighbours are fighting about something! Could you Help? Choices:[Yes,No]: Yes -> Go to scene, No -> NPC: Ugh.. I doubt they will resolve it on their own.."]
        text = ["Person 1: What do you mean this is your money?","Person 2: This is something that I worked for!",
        "Person 1: We both worked! I am just demanding for what I righteously shall get!","Person 2: It is unfair! All you did was stare..",
        "Person 1: You are being rude!","Person 2: What do you want now?","Me : I came to help you with your conflict..",
        "Person 2: If you are not willing to give us money, You might as well get lost!","Friend: We could give them the money we gathered, ain't that a good idea?"];
        choice = ["Choice: Give money","Choice: Get Lost"]
        textAfter1 = ["Person 1: That's so generous of you!","Person 2: I don't believe this! You sir, have a big heart", "Friend: I knew you had this in you. You are a great person!"];
        textAfter2 = ["Person 1: Why would you even bother asking then?","Friend: I don't understand, we could have this solved already..", "me: We can't be spending our money around like this.."];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
