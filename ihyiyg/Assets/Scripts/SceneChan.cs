using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChan : MonoBehaviour
{
    
    public bool firstTime = true;
    private void Awake() {
        //firstTime = intToBool(PlayerPrefs.GetInt("First"));
    }

    public void StartGame()
    {
        Invoke("LoadGameScene", 0.3f); // Calls LoadGameScene after 2 seconds
    }

    public void CloseGame()
    {
        Invoke("QuitApplication", 0.3f); // Calls QuitApplication after 2 seconds
    }

    private void LoadGameScene()
    {
        if (firstTime){
            Debug.Log(":O");
            

            SceneManager.LoadScene("Scenes/Intro");
            PlayerPrefs.SetInt("First", 0); 
        }
        //else SceneManager.LoadScene("Scenes/MainScene_tutorial");
        else SceneManager.LoadScene("Scenes/MainScene");
    }

   public void LoadNewGame()
    {
        SceneManager.LoadScene("Scenes/MainScene");
    }

    private void QuitApplication()
    {
        Application.Quit();
    }

    private bool intToBool(int i) {
        if (i == 0) return false;
        else return true;
    }
}
