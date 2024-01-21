using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum Status {nic,owca,wilk}

public class SpriteChanger : MonoBehaviour
{

    [SerializeField] private Sprite[] buttonSprites;
    [SerializeField] private Image targetButton;
    private Status status_obiektu = Status.nic;
    public GnomeScript associatedGnome; // Reference to the associated GnomeScript

    public Status GetStatus()
    {
        return status_obiektu;
    }


    public void ChangeSprite(){
        
        if (targetButton.sprite == buttonSprites[0]){
            targetButton.sprite = buttonSprites[1];
            status_obiektu = Status.owca;

            return;
        }
        else if(targetButton.sprite == buttonSprites[1]){
            targetButton.sprite = buttonSprites[2];
            status_obiektu = Status.wilk;
            return;
        }
        // moze to mozna po prostu zrobic jako targetButton.Sprite = buttonSprites[0];
        else if(targetButton.sprite == buttonSprites[2]){
            targetButton.sprite = buttonSprites[0];
            status_obiektu = Status.nic;

            return;
        }
        
    }
}

