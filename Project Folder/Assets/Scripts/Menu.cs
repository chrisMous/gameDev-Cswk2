using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static void PlayGame(){
        //playerMovement.movement = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Town");
    }

    public void QuitGame(){
        Application.Quit();
    }
    public void LaunchMenu(){
        SceneManager.LoadScene("menu");
    }
}
