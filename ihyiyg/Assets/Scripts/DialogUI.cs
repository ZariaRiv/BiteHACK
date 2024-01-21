using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;


public class DialogUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogObject testDialogue;
    [SerializeField] private GameObject dialogueBox;

    public bool IsOpen {get; private set; }
    
    private TypewritterEffect typewritterEffect;

    private void Start()
    {
       // textLabel.text = "Hello!\n This is my new line.";
      // GetComponent<TypewritterEffect>().Run("Hellajhbfiluafiyugflo!\n This is maefahifuhay new line.", textLabel);
        typewritterEffect =GetComponent<TypewritterEffect>();
        CloseDialogueBox();
        Debug.Log("Start");
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            ShowDialogueChange(testDialogue);
        }
        ShowDialogueChange(testDialogue); //// to tutaj odkomentuj i ustaw jakies rzeczy potem, ale to potem, na razie troche dziala
        
    
    
    }

    private void ShowDialogueChange(DialogObject dialogueObject)
    {
        IsOpen = true;
        dialogueBox.SetActive(true);
        StartCoroutine(StepThroughDialougeChange(dialogueObject));
    }

    private IEnumerator StepThroughDialougeChange(DialogObject dialogueObject)
    {
        //yield return new WaitForSeconds(2);

        foreach (string dialogue in dialogueObject.Dialogue)
        {
            yield return typewritterEffect.Run(dialogue, textLabel);
            yield return new WaitForSeconds(1f);

        }
        CloseDialogueBox();
        Debug.Log("Teraz powinno zaladowac scenke");
        SceneManager.LoadScene("Scenes/MainScene_tutorial");///?"Scenes/Main"
    }

    public void ShowDialogue(DialogObject dialogueObject)
    {
        IsOpen = true;
        dialogueBox.SetActive(true);
        StartCoroutine(StepThroughDialougeChange(dialogueObject));
    }

    public IEnumerator StepThroughDialouge(DialogObject dialogueObject)
    {
        //yield return new WaitForSeconds(2);
        foreach (string dialogue in dialogueObject.Dialogue)
        {
            yield return typewritterEffect.Run(dialogue, textLabel);
            yield return new WaitUntil(()=> Input.GetKeyDown(KeyCode.Space));

        }
        CloseDialogueBox();
        //SceneManager.LoadScene("Scenes/MainScene_tutorial");
    }

    private void CloseDialogueBox(){
        IsOpen = false;
        dialogueBox.SetActive(false);
        textLabel.text=string.Empty;
    }
}
