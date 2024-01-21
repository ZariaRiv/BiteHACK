using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_1 : MonoBehaviour
{
    public float eyelidSpeed = 2.5f;
    public GameObject eyelidTop;
    public GameObject eyelidBottom;
    public Canvas buttonCanvas; // Reference to the canvas containing the buttons
    

    private float[] grandmaAwakeTimes = {5.0f, 5.0f, 5.0f, 5.0f, 5.0f, 5.0f};
    private float[] grandmaSleepTimes = {2.0f, 2.0f, 2.0f, 2.0f, 2.0f, 2.0f};

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
        //wylaczanie przyciskow
        //buttonCanvas.enabled = false;
        Debug.Log("grandmaClosesEyes - END");
    }

    private void swap(GameObject g1, GameObject g2) {
        Vector3 temp = g1.transform.position;
        g1.transform.position = g2.transform.position;
        g2.transform.position = temp;
    }

    void grandmaOpenesEyes() {
        Debug.Log("grandmaOpenesEyes - START");
        //Podmianki assetów w casach
        /*switch(cycleCounter) {
            case 1:
                Debug.Log("111111");
                GameObject[] allGnomes = GameObject.FindGameObjectsWithTag("GNOM");

                //GameObject badGnome;
                foreach(GameObject gnom in allGnomes) {
                    if(gnom.GetComponent<GnomeScript>().wolf) {
                        GameObject badGnome = gnom;

                        GameObject[] allPlants = GameObject.FindGameObjectsWithTag("PLANT");
                        float smallestDistance = float.MaxValue;
                        GameObject closestPlant = allPlants[0];
                        foreach(GameObject plant in allPlants) {
                            float distance = Vector3.Distance(plant.transform.position, badGnome.transform.position);
                            if(distance < smallestDistance) {
                                smallestDistance = distance;
                                closestPlant = plant;
                            }
                        }

                        //GameObject plant = GameObject.Find("Plant (1)");
                        closestPlant.GetComponent<PlantsScript>().changePlantSpriteToBroken();
                    }
                }

                foreach(GameObject gnom in allGnomes) {
                    swap(gnom, allGnomes[Random.Range(0, allGnomes.Length)]);
                }

                
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
        }*/

        Debug.Log("111111");
        GameObject[] allGnomes = GameObject.FindGameObjectsWithTag("GNOM");

        //GameObject badGnome;
        foreach(GameObject gnom in allGnomes) {
            if(gnom.GetComponent<GnomeScript>().wolf) {
                GameObject badGnome = gnom;

                GameObject[] allPlants = GameObject.FindGameObjectsWithTag("PLANT");
                float smallestDistance = float.MaxValue;
                GameObject closestPlant = allPlants[0];
                foreach(GameObject plant in allPlants) {
                    if(plant.GetComponent<PlantsScript>().destroyed == false) {
                        float distance = Vector3.Distance(plant.transform.position, badGnome.transform.position);
                        if(distance < smallestDistance) {
                            smallestDistance = distance;
                            closestPlant = plant;
                        }
                    }
                }

                //GameObject plant = GameObject.Find("Plant (1)");
                closestPlant.GetComponent<PlantsScript>().changePlantSpriteToBroken();
            }
        }

        foreach(GameObject gnom in allGnomes) {
            swap(gnom, allGnomes[Random.Range(0, allGnomes.Length)]);
        }

        grandmaOpenesEyesAnimation = true;
        cycleCounter += 1;
        // Enable the entire canvas with buttons
        //buttonCanvas.enabled = true;
        Debug.Log("grandmaOpenesEyes - END");
    }
}
