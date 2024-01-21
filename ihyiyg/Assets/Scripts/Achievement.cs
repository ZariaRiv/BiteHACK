using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achievement : MonoBehaviour
{
    public Sprite buttonSprite; // Assign your sprite in the Inspector

    private void Start()
    {
        CreateButton();
    }

    private void CreateButton()
    {
        // Create a new button
        GameObject buttonGameObject = new GameObject("AchievementButton");
        Button achievementButton = buttonGameObject.AddComponent<Button>();
        buttonGameObject.transform.SetParent(transform, false);

        // Add an Image component to the button
        Image buttonImage = buttonGameObject.AddComponent<Image>();
        buttonImage.sprite = buttonSprite;

        // Set alpha value (transparency) to 0.5 (adjust as needed)
        Color buttonColor = buttonImage.color;
        buttonColor.a = 0.01f;
        buttonImage.color = buttonColor;

        // Add a click listener to the button
        achievementButton.onClick.AddListener(OpenAchievementScene);
    }

    private void OpenAchievementScene()
    {
        SceneManager.LoadScene("Achievement");
    }
}
