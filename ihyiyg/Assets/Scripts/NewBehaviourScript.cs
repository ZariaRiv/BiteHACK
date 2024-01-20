using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] private Sprite[] buttonSprites;
    [SerializeField] private Image targetButton;

    public void ChangeSprite(){
        
        if (targetButton.sprite == buttonSprites[0]){
            targetButton.sprite = buttonSprites[1];
            return;
        }
        else if(targetButton.sprite == buttonSprites[1]){
            targetButton.sprite = buttonSprites[2];
            return;
        }
        // moze to mozna po prostu zrobic jako targetButton.Sprite = buttonSprites[0];
        else if(targetButton.sprite == buttonSprites[2]){
            targetButton.sprite = buttonSprites[0];
            return;
        }
        
    }
}

