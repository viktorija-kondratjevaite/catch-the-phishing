using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
    public GameObject menu;
    public GameObject help;
    public GameObject settings;
    public GameObject moreAboutPhishing;
    // public GameObject music;
    public AudioSource music;
    private bool musicMuted = false;

    public void Start() {
        menu.SetActive(true);
    }

    public void OpenNewObject(GameObject newObject) {
        newObject.SetActive(true);
    }

    public void BackToMenu(GameObject currentObject){
        currentObject.SetActive(false);
        menu.SetActive(true);
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void MuteMusic() {
        if(musicMuted == false) {
            music.Stop();
            musicMuted = true;
        }
        else {
            music.Play();
            musicMuted = false;
        }
    }

    public void Play() {
        GameManager.ComeBackToIsland();
    }

}
