using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private List<Sprite> tutorialSprites  = new List<Sprite>();
    [SerializeField][TextArea] private List<string> tutorialTexts  = new List<string>();
    private Image _image;
    private int lastInt = -1;
    [SerializeField] private TextMeshProUGUI tutorialText;

    [SerializeField] private Button pauseButton;

    //private int countTip = 0;

    private void Start() {
        _image = GetComponent<Image>();
        gameObject.SetActive(false);
        ActivateTutorial(0);  
    }

    public void ActivateTutorial(int i) {
        _image.sprite = tutorialSprites[i];
        _image.color = new Color32(255,255,255,255);
        tutorialText.text = tutorialTexts[i];
        Time.timeScale = 0f;
        lastInt = i;
        gameObject.SetActive(true);

         // Disable and hide the PauseButton
        if (pauseButton != null) {
            pauseButton.gameObject.SetActive(false);
        }

        Debug.Log("last int toooo...du du du dummmm" + lastInt.ToString());
    }

/*    public void CheckTipTutorial() {
        countTip++;
        if (countTip > 1) return;
        _image.sprite = tutorialSprites[10];
        _image.color = new Color32(255,255,255,255);
        tutorialText.text = tutorialTexts[10];
        Time.timeScale = 0f;
        lastInt = 10;
        gameObject.SetActive(true);
    }
    */

    public void DeactivateTutorial() {
        gameObject.SetActive(false);
        _image.sprite = null;
        tutorialText.text = "";
        _image.color = new Color32(255,255,255,0);
        Time.timeScale = 1f;
         // Enable and show the PauseButton
        if (pauseButton != null) {
            pauseButton.gameObject.SetActive(true);
        }

        Debug.Log("AAAA" + lastInt.ToString());
        switch(lastInt){
            case 0:
                ActivateTutorial(1);
                break;
            case 1:
                ActivateTutorial(2);
                break;
            /*case 7:
                ActivateTutorial(8);
                break;
            default:
                break;
                */
        }
    }
}
