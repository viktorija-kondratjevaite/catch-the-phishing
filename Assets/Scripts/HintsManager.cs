using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintsManager : MonoBehaviour {
    public GameObject defaultHint;
    public GameObject firstHint;
    public GameObject secondHint;
    public GameObject thirdHint;
    public GameObject fourthHint;
    public GameObject fifthHint;
    public GameObject sixthHint;
    public GameObject seventhHint;
    public GameObject eighthHint; 

    void Start() {
        defaultHint.SetActive(true);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.H)) 
        {
            defaultHint.SetActive(false);
            ShowHints();
        }
    }

    public void ShowHints() {
        Debug.Log(GameManager.currentTask);
        switch (GameManager.currentTask) {
            case GameManager.BOAT:
                handleBoatHint();
                break;
            case GameManager.CHEST:
                handleChestHint();
                break;
            case GameManager.MUSHROOM:
                showHint(thirdHint);
                break;
            case GameManager.ROCK:
                showHint(fourthHint);
                break;
            case GameManager.SUNFLOWER:
                showHint(fifthHint);
                break;
            case GameManager.CAMPFIRE:
                showHint(sixthHint);
                break;
        }       
    }

    private void handleBoatHint() {
        if (GameManager.codeInputCorrect) {
            showHint(eighthHint);
        } else {
            showHint(firstHint);
        }
    }

    private void handleChestHint() {
        if (GameManager.chestCodeAcquired) {
            showHint(seventhHint);
        } else {
            showHint(secondHint);
        }
    }

    private void showHint(GameObject hintObject) {
        hintObject.SetActive(true);
        StartCoroutine(GameManager.RemoveAfterSeconds(7, hintObject));
        StartCoroutine(ShowDefaultHint(7));
    }

    public IEnumerator ShowDefaultHint(int seconds) {
        yield return new WaitForSeconds(seconds);
        defaultHint.SetActive(true);
    }
}
