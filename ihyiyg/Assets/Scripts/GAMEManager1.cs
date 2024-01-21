using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMEManager1 : MonoBehaviour
{
    //public GameObject wolfPanel;
    public GameObject buttonPanel;
    public Button confirmButton;
    public Button pauseButton;
    public GnomeScript[] allGnomes;
    

    void Start()
    {
        // Find all gnomes in the scene
        allGnomes = FindObjectsOfType<GnomeScript>();

        // Disable the buttons panel initially
        //wolfPanel.SetActive(false);

        // Set up button click events
        confirmButton.onClick.AddListener(OnConfirmButtonClick);
        confirmButton.gameObject.SetActive(false);
        

        // Invoke the CheckWolfStatus function after 5 seconds
        //Invoke("StopGame", 4f);
        

    }

    void Update()
    {
        // Your other game logic
    }

    // Function to stop the game and display buttons
    public void StopGame()
    {
        Debug.Log("Gra powinna sie zatrzymac");
        // Show the buttons panel
        //wolfPanel.SetActive(true);
        confirmButton.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        //confirmButton.gameObject.SetActive(true);
        //buttonPanel.SetActive(true);
        Time.timeScale = 0; // Pause the game
    }

    // Function to handle confirm button click
    private void OnConfirmButtonClick()
    {
        bool wolfFound = CheckWolfStatus();
        if (wolfFound)
        {
            Debug.Log("Wilk znaleziony");
            SceneManager.LoadScene("Scenes/sukces");
        }
        else
        {
            Debug.Log("Wilk nie znaleziony");
            SceneManager.LoadScene("Scenes/porazka");
        }

        // Resume the game
        Time.timeScale = 1;
        //wolfPanel.SetActive(false);
        buttonPanel.SetActive(false);
    }

    // Function to handle yes button click
    private void OnYesButtonClick()
    {
        // Set wolf status to true for all gnomes
        foreach (GnomeScript gnome in allGnomes)
        {
            gnome.ToggleWolfStatus();
        }
    }

    // Function to handle no button click
    private void OnNoButtonClick()
    {
        // Do nothing for now, you can add more logic here if needed
    }

    // Function to check if any gnome has wolf status set to true
    private bool CheckWolfStatus()
    {
        foreach (GnomeScript gnome in allGnomes)
        {
            //if (gnome.wolf)
        if (gnome.wolf && (gnome.button != null && gnome.button.GetComponent<SpriteChanger>().GetStatus() == Status.wilk))
            {
                return true; // Wolf found
            }
        }
        return false; // Wolf not found
    }
}
