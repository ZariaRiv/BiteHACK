using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public Canvas buttonCanvas; // Reference to the canvas containing the buttons

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the PausePanel is initially inactive
        PausePanel.SetActive(false);
    }
    public void Pause(){

        //PausePanel.SetActive(true);
        //Time.timeScale = 0;

        // Activate the PausePanel only if it's not active
        if (!PausePanel.activeSelf)
        {
            // Disable the entire canvas with buttons
            buttonCanvas.enabled = false;

            PausePanel.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void Continue(){

        // Enable the entire canvas with buttons
        buttonCanvas.enabled = true;

        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Home(){
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
