using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWindow : MonoBehaviour {

    public void Quit() {
        Application.Quit();
    }

    public void MoreAbout() {
        GameManager.OpenMoreAboutPhishing();
    }
}
