using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
    public GameObject menuStart;
    public GameObject menuContinue;
    public GameObject help;
    public GameObject settings;
    public GameObject moreAboutPhishing;
    public AudioSource music;
    public static bool isStartOfGame = true;

    public void Start() {
        if(isStartOfGame)
            MuteMusic();
        ChooseMenu();
    }

    public void OpenNewObject(GameObject newObject) {
        newObject.SetActive(true);
    }

    public void ChooseMenu() {
        if(isStartOfGame == true) {
            menuStart.SetActive(true);
        }
        else {
            menuContinue.SetActive(true);
        }
    }

    public void BackToMenu(GameObject currentObject){
        currentObject.SetActive(false);
        ChooseMenu();
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void MuteMusic() {
        if(GameManager.musicMuted == false) {
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusicManager>().StopMusic();
            GameManager.musicMuted = true;
        } else {
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusicManager>().PlayMusic();
            GameManager.musicMuted = false;
        }
    }

    public void Play() {
        isStartOfGame = false;
        GameManager.ComeBackToIsland();
    }
}
