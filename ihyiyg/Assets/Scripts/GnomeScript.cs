using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GnomeType
{
    girlGnome,
    girlGnomeWithAxe,
    girlGnomeWithPruner,
    girlGnomeWithShovel,
    manGnome,
    manGnomeWithAxe,
    manGnomeWithPruner,
    manGnomeWithShovel,
    bodybuilderGnome,
    bodybuilderGnomeWithAxe,
    bodybuilderGnomeWithPruner,
    bodybuilderGnomeWithShovel,
    beachgoerGnome,
    beachgoerGnomeWithAxe,
    beachgoerGnomeWithPruner,
    beachgoerGnomeWithShovel
}

public class GnomeScript : MonoBehaviour
{
    public GnomeType gnomeType;
    public Sprite girlGnome;
    public Sprite girlGnomeWithAxe;
    public Sprite girlGnomeWithPruner;
    public Sprite girlGnomeWithShovel;
    public Sprite manGnome;
    public Sprite manGnomeWithAxe;
    public Sprite manGnomeWithPruner;
    public Sprite manGnomeWithShovel;
    public Sprite bodybuilderGnome;
    public Sprite bodybuilderGnomeWithAxe;
    public Sprite bodybuilderGnomeWithPruner;
    public Sprite bodybuilderGnomeWithShovel;
    public Sprite beachgoerGnome;
    public Sprite beachgoerGnomeWithAxe;
    public Sprite beachgoerGnomeWithPruner;
    public Sprite beachgoerGnomeWithShovel;
    public SpriteRenderer spriteRenderer;

    public bool wolf = false; // Boolean to indicate if the wolf is found
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        changeGnomeSprite(gnomeType);
        //changeGnomeSprite2();
        button.GetComponent<SpriteChanger>().associatedGnome = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeGnomeSprite2(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }

    public void changeGnomeSprite(GnomeType gnomeType) {
        switch(gnomeType) {
            case GnomeType.girlGnome:
                spriteRenderer.sprite = girlGnome; 
                break;
            case GnomeType.girlGnomeWithAxe:
                spriteRenderer.sprite = girlGnomeWithAxe; 
                break;
            case GnomeType.girlGnomeWithPruner:
                spriteRenderer.sprite = girlGnomeWithPruner; 
                break;
            case GnomeType.girlGnomeWithShovel:
                spriteRenderer.sprite = girlGnomeWithShovel; 
                break;
            case GnomeType.manGnome:
                spriteRenderer.sprite = manGnome; 
                break;
            case GnomeType.manGnomeWithAxe:
                spriteRenderer.sprite = manGnomeWithAxe; 
                break;
            case GnomeType.manGnomeWithPruner:
                spriteRenderer.sprite = manGnomeWithPruner; 
                break;
            case GnomeType.manGnomeWithShovel:
                spriteRenderer.sprite = manGnomeWithShovel; 
                break;
            case GnomeType.bodybuilderGnome:
                spriteRenderer.sprite = bodybuilderGnome; 
                break;
            case GnomeType.bodybuilderGnomeWithAxe:
                spriteRenderer.sprite = bodybuilderGnomeWithAxe; 
                break;
            case GnomeType.bodybuilderGnomeWithPruner:
                spriteRenderer.sprite = bodybuilderGnomeWithPruner; 
                break;
            case GnomeType.bodybuilderGnomeWithShovel:
                spriteRenderer.sprite = bodybuilderGnomeWithShovel; 
                break;
            case GnomeType.beachgoerGnome:
                spriteRenderer.sprite = beachgoerGnome; 
                break;
            case GnomeType.beachgoerGnomeWithAxe:
                spriteRenderer.sprite = beachgoerGnomeWithAxe; 
                break;
            case GnomeType.beachgoerGnomeWithPruner:
                spriteRenderer.sprite = beachgoerGnomeWithPruner; 
                break;
            case GnomeType.beachgoerGnomeWithShovel:
                spriteRenderer.sprite = beachgoerGnomeWithShovel; 
                break;
            default:
                break;
        }
    }

    public void ToggleWolfStatus()
    {
        wolf = !wolf; // Toggle the wolf status
    }
}
