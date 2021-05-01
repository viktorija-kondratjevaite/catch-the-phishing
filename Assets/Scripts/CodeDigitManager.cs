using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeDigitManager : MonoBehaviour {
    public GameObject firstDigit;
    public GameObject secondDigit;
    public GameObject thirdDigit;
    public GameObject fourthDigit;
    public GameObject key;

    public void Update() {
        switch (GameManager.currentTask) {
            case GameManager.ROCK:
                firstDigit.SetActive(true);
                break;
            case GameManager.SUNFLOWER:
                firstDigit.SetActive(true);
                secondDigit.SetActive(true);
                break;
            case GameManager.CAMPFIRE:
                firstDigit.SetActive(true);
                secondDigit.SetActive(true);
                thirdDigit.SetActive(true);
                break;
            case GameManager.CHEST:
                if (GameManager.chestCodeAcquired) {
                    firstDigit.SetActive(true);
                    secondDigit.SetActive(true);
                    thirdDigit.SetActive(true);
                    fourthDigit.SetActive(true);
                }
                break;
            case GameManager.BOAT: 
                if (GameManager.codeInputCorrect) {
                    firstDigit.SetActive(false);
                    secondDigit.SetActive(false);
                    thirdDigit.SetActive(false);
                    fourthDigit.SetActive(false);
                    key.SetActive(true);
                }
                break;
        }       
    }
}
