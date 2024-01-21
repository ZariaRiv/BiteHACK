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
    beachgoerGnomeWithShovel,

    shepherdGnome,
    shepherdGnomeWithAxe,
    shepherdGnomeWithPruner,
    shepherdGnomeWithShovel
}

public class GnomeScript : MonoBehaviour
{
    public GnomeType gnomeType;

    public Sprite girlGnome;
    public Sprite girlGnomeWithAxe;
    public Sprite girlGnomeWithPruner;
    public Sprite girlGnomeWithShovel;
    public Sprite girlGnomeSelected;
    public Sprite girlGnomeWithAxeSelected;
    public Sprite girlGnomeWithPrunerSelected;
    public Sprite girlGnomeWithShovelSelected;

    public Sprite manGnome;
    public Sprite manGnomeWithAxe;
    public Sprite manGnomeWithPruner;
    public Sprite manGnomeWithShovel;
    public Sprite manGnomeSelected;
    public Sprite manGnomeWithAxeSelected;
    public Sprite manGnomeWithPrunerSelected;
    public Sprite manGnomeWithShovelSelected;

    public Sprite bodybuilderGnome;
    public Sprite bodybuilderGnomeWithAxe;
    public Sprite bodybuilderGnomeWithPruner;
    public Sprite bodybuilderGnomeWithShovel;
    public Sprite bodybuilderGnomeSelected;
    public Sprite bodybuilderGnomeWithAxeSelected;
    public Sprite bodybuilderGnomeWithPrunerSelected;
    public Sprite bodybuilderGnomeWithShovelSelected;

    public Sprite beachgoerGnome;
    public Sprite beachgoerGnomeWithAxe;
    public Sprite beachgoerGnomeWithPruner;
    public Sprite beachgoerGnomeWithShovel;
    public Sprite beachgoerGnomeSelected;
    public Sprite beachgoerGnomeWithAxeSelected;
    public Sprite beachgoerGnomeWithPrunerSelected;
    public Sprite beachgoerGnomeWithShovelSelected;

    public Sprite shepherdGnome;
    public Sprite shepherdGnomeWithAxe;
    public Sprite shepherdGnomeWithPruner;
    public Sprite shepherdGnomeWithShovel;
    public Sprite shepherdGnomeSelected;
    public Sprite shepherdGnomeWithAxeSelected;
    public Sprite shepherdGnomeWithPrunerSelected;
    public Sprite shepherdGnomeWithShovelSelected;

    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        changeGnomeSprite(gnomeType);
        //changeGnomeSprite2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeGnomeSprite2(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }

    public void changeGnomeToUnselected() {
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
            case GnomeType.shepherdGnome:
                spriteRenderer.sprite = shepherdGnome; 
                break;
            case GnomeType.shepherdGnomeWithAxe:
                spriteRenderer.sprite = shepherdGnomeWithAxe; 
                break;
            case GnomeType.shepherdGnomeWithPruner:
                spriteRenderer.sprite = shepherdGnomeWithPruner; 
                break;
            case GnomeType.shepherdGnomeWithShovel:
                spriteRenderer.sprite = shepherdGnomeWithShovel; 
                break;
            default:
                break;
        }
    }

    public void changeGnomeToSelected() {
        switch(gnomeType) {
            case GnomeType.girlGnome:
                spriteRenderer.sprite = girlGnomeSelected; 
                break;
            case GnomeType.girlGnomeWithAxe:
                spriteRenderer.sprite = girlGnomeWithAxeSelected; 
                break;
            case GnomeType.girlGnomeWithPruner:
                spriteRenderer.sprite = girlGnomeWithPrunerSelected; 
                break;
            case GnomeType.girlGnomeWithShovel:
                spriteRenderer.sprite = girlGnomeWithShovelSelected; 
                break;
            case GnomeType.manGnome:
                spriteRenderer.sprite = manGnomeSelected; 
                break;
            case GnomeType.manGnomeWithAxe:
                spriteRenderer.sprite = manGnomeWithAxeSelected; 
                break;
            case GnomeType.manGnomeWithPruner:
                spriteRenderer.sprite = manGnomeWithPrunerSelected; 
                break;
            case GnomeType.manGnomeWithShovel:
                spriteRenderer.sprite = manGnomeWithShovelSelected; 
                break;
            case GnomeType.bodybuilderGnome:
                spriteRenderer.sprite = bodybuilderGnomeSelected; 
                break;
            case GnomeType.bodybuilderGnomeWithAxe:
                spriteRenderer.sprite = bodybuilderGnomeWithAxeSelected; 
                break;
            case GnomeType.bodybuilderGnomeWithPruner:
                spriteRenderer.sprite = bodybuilderGnomeWithPrunerSelected; 
                break;
            case GnomeType.bodybuilderGnomeWithShovel:
                spriteRenderer.sprite = bodybuilderGnomeWithShovelSelected; 
                break;
            case GnomeType.beachgoerGnome:
                spriteRenderer.sprite = beachgoerGnomeSelected; 
                break;
            case GnomeType.beachgoerGnomeWithAxe:
                spriteRenderer.sprite = beachgoerGnomeWithAxeSelected; 
                break;
            case GnomeType.beachgoerGnomeWithPruner:
                spriteRenderer.sprite = beachgoerGnomeWithPrunerSelected; 
                break;
            case GnomeType.beachgoerGnomeWithShovel:
                spriteRenderer.sprite = beachgoerGnomeWithShovelSelected; 
                break;
            case GnomeType.shepherdGnome:
                spriteRenderer.sprite = shepherdGnomeSelected; 
                break;
            case GnomeType.shepherdGnomeWithAxe:
                spriteRenderer.sprite = shepherdGnomeWithAxeSelected; 
                break;
            case GnomeType.shepherdGnomeWithPruner:
                spriteRenderer.sprite = shepherdGnomeWithPrunerSelected; 
                break;
            case GnomeType.shepherdGnomeWithShovel:
                spriteRenderer.sprite = shepherdGnomeWithShovelSelected; 
                break;
            default:
                break;
        }
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
            case GnomeType.shepherdGnome:
                spriteRenderer.sprite = shepherdGnome; 
                break;
            case GnomeType.shepherdGnomeWithAxe:
                spriteRenderer.sprite = shepherdGnomeWithAxe; 
                break;
            case GnomeType.shepherdGnomeWithPruner:
                spriteRenderer.sprite = shepherdGnomeWithPruner; 
                break;
            case GnomeType.shepherdGnomeWithShovel:
                spriteRenderer.sprite = shepherdGnomeWithShovel; 
                break;
            default:
                break;
        }
    }
}
