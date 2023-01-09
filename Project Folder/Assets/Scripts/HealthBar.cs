using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;

    public void decrease(){
        if (slider.value>=1)
        slider.value = slider.value-1;
    }
    public void Increase(){
        Debug.Log("Increase");
        if(slider.value<=5)
            slider.value = slider.value+1;
    }
    public void setFriend(int amount){
        slider.value = amount;
    }
}
