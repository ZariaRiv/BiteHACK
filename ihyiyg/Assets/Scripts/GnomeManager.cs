using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GnomeScript> gnomes;
    public List<Sprite> availableSprites; // Populate this list with your available sprites

    // Start is called before the first frame update
    void Start()
    {
        // Assume you have a list of gnomes in your scene
        // You can manually assign them in the Unity Editor or find them dynamically
        gnomes = new List<GnomeScript>(FindObjectsOfType<GnomeScript>());

        //Invoke("ChangeAllGnomesSprites", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        // Your other game logic
    }

    /*public void ChangeAllGnomesSprites()
    {
        // Shuffle the list of gnomes
        ShuffleList(gnomes);

        // Iterate through the shuffled gnomes and assign a random sprite
        for (int i = 0; i < gnomes.Count; i++)
        {
            if (availableSprites.Count > 0)
            {
                // Choose a random sprite from the available list
                int randomIndex = Random.Range(0, availableSprites.Count);

                // Convert the Sprite to the corresponding GnomeType (you need to define this conversion logic)
                GnomeType randomGnomeType = ConvertSpriteToGnomeType(availableSprites[randomIndex]);

                // Use the changeGnomeSprite method with the randomly selected GnomeType
                gnomes[i].changeGnomeSprite(randomGnomeType);

                // Remove the chosen sprite from the available list to avoid duplicates
                availableSprites.RemoveAt(randomIndex);
            }
            else
            {
                Debug.LogWarning("Not enough available sprites for all gnomes.");
                break;
            }
        }
    }*/
public void ChangeAllGnomesSprites()
{
    // Shuffle the list of gnomes
    ShuffleList(gnomes);

    // Iterate through the shuffled gnomes and assign a random sprite
    for (int i = 0; i < gnomes.Count; i++)
    {
        if (availableSprites.Count > 0)
        {
            // Choose a random sprite from the available list
            int randomIndex = Random.Range(0, availableSprites.Count);

            // Use the chosen sprite directly
            gnomes[i].changeGnomeSprite2(availableSprites[randomIndex]);

            // Remove the chosen sprite from the available list to avoid duplicates
            availableSprites.RemoveAt(randomIndex);
        }
        else
        {
            Debug.LogWarning("Not enough available sprites for all gnomes.");
            break;
        }
    }
}


    // Helper method to shuffle a list
    private void ShuffleList<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    // Example: Convert Sprite to GnomeType (you need to define your own logic)
    private GnomeType ConvertSpriteToGnomeType(Sprite sprite)
    {
        // Implement your logic here to determine the corresponding GnomeType based on the sprite
        // This may involve checking the name, tag, or other properties of the sprite
        // Return the appropriate GnomeType
        return GnomeType.girlGnome; // Replace with your logic
    }
}
