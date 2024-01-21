using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_1 : MonoBehaviour
{
    public float eyelidSpeed = 2.5f;
    public GameObject eyelidTop;
    public GameObject eyelidBottom;

    private float[] grandmaAwakeTimes = {5.0f, 5.0f};
    private float[] grandmaSleepTimes = {3.0f, 3.0f};

    private bool grandmaClosesEyesAnimation = false;
    private bool grandmaOpenesEyesAnimation = false;
    private int cycleCounter = 1;
    private int maxNumberOfCycles;

    void Update() {
        if(grandmaClosesEyesAnimation) {
            if(eyelidTop.transform.position.y > 3 && eyelidBottom.transform.position.y < -3) {
                eyelidTop.transform.Translate(Vector3.down * eyelidSpeed * Time.deltaTime);
                eyelidBottom.transform.Translate(Vector3.up * eyelidSpeed * Time.deltaTime);
            } else {
                grandmaClosesEyesAnimation = false;
                Invoke("grandmaOpenesEyes", grandmaSleepTimes[cycleCounter-1]);
            }
        }

        if(grandmaOpenesEyesAnimation) { 
            if(eyelidTop.transform.position.y < 11 && eyelidBottom.transform.position.y > -11) {
                eyelidTop.transform.Translate(Vector3.up * eyelidSpeed * Time.deltaTime);
                eyelidBottom.transform.Translate(Vector3.down * eyelidSpeed * Time.deltaTime);
            } else {
                grandmaOpenesEyesAnimation = false;
                if(cycleCounter <= maxNumberOfCycles) {
                    Invoke("grandmaClosesEyes", grandmaAwakeTimes[cycleCounter-1]);
                } else {
                    Debug.Log("SZUKANIE WILKA!"); //Ale podmianka planszy musi być w switch case!!!
                }
            }
        } 
    }

    void Start() {
        maxNumberOfCycles = grandmaAwakeTimes.Length;
        Debug.Log("Start");
        Debug.Log(maxNumberOfCycles);
        Invoke("grandmaClosesEyes", grandmaAwakeTimes[cycleCounter-1]);
    }

    void grandmaClosesEyes() {
        Debug.Log("grandmaClosesEyes - START");
        grandmaClosesEyesAnimation = true;
        Debug.Log("grandmaClosesEyes - END");
    }

    void grandmaOpenesEyes() {
        Debug.Log("grandmaOpenesEyes - START");
        //Podmianki assetów w casach
        switch(cycleCounter) {
            case 1:
                Debug.Log("111111");
                break;
            case 2:
                Debug.Log("222222"); // W tym przypadku tutaj powinna być podmianka planszy do szukania wilka
                break;
            case 3:
                Debug.Log("333333");
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                Debug.Log("ERROR: switch case default value!");
                break;
        }

        grandmaOpenesEyesAnimation = true;
        cycleCounter += 1;
        Debug.Log("grandmaOpenesEyes - END");
    }
}
