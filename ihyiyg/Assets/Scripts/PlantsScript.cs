using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlantType
{
    tree,
    patch,
    stone1,
    stone2,
    bush1,
    bush2,
    tools,
    gnome_slot,
    wheelbarrow
}

public class PlantsScript : MonoBehaviour
{
    public PlantType plantType;

    public Sprite tree;
    public Sprite b_tree;
    public Sprite patch;
    public Sprite b_patch;
    public Sprite stone1;
    public Sprite stone2;
    public Sprite b_stone;
    public Sprite bush1;
    public Sprite bush2;
    public Sprite b_bush;
    public Sprite tools;
    public Sprite b_tools;
    public Sprite wheelbarrow;
    public Sprite b_wheelbarrow;
    public Sprite gnome_slot;

    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        changePlantSprite(plantType);
        //changePlantSpriteToBroken();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changePlantSpriteToBroken() {
        switch(plantType) {
            case PlantType.tree:
                spriteRenderer.sprite = b_tree; 
                break;
            case PlantType.patch:
                spriteRenderer.sprite = b_patch; 
                break;
            case PlantType.stone1:
                spriteRenderer.sprite = b_stone; 
                break;
            case PlantType.stone2:
                spriteRenderer.sprite = b_stone; 
                break;
            case PlantType.bush1:
                spriteRenderer.sprite = b_bush; 
                break;
            case PlantType.bush2:
                spriteRenderer.sprite = b_bush; 
                break;
            case PlantType.tools:
                spriteRenderer.sprite = b_tools; 
                break;
            case PlantType.wheelbarrow:
                spriteRenderer.sprite = b_wheelbarrow; 
                break;
            default:
                break;
        }
    }

    public void changePlantSprite(PlantType plantType) {
        switch(plantType) {
            case PlantType.tree:
                spriteRenderer.sprite = tree; 
                break;
            case PlantType.patch:
                spriteRenderer.sprite = patch; 
                break;
            case PlantType.stone1:
                spriteRenderer.sprite = stone1; 
                break;
            case PlantType.stone2:
                spriteRenderer.sprite = stone2; 
                break;
            case PlantType.bush1:
                spriteRenderer.sprite = bush1; 
                break;
            case PlantType.bush2:
                spriteRenderer.sprite = bush2; 
                break;
            case PlantType.tools:
                spriteRenderer.sprite = tools; 
                break;
            case PlantType.gnome_slot:
                spriteRenderer.sprite = gnome_slot; 
                break;
            case PlantType.wheelbarrow:
                spriteRenderer.sprite = wheelbarrow; 
                break;
            default:
                break;
        }
    }
}
