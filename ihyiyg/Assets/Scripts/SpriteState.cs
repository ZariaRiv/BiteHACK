using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteState : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.SpriteState spriteState;
    [SerializeField] private Button button;
    // Start is called before the first frame update
    public void SpriteChange()
    {
        button.spriteState =spriteState;
    }
}
