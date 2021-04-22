using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatClicker : MonoBehaviour
{
    public GameObject boatHint; 

    void Start()
    {
        boatHint.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShowHint();
            GameManager.boatClicked = true; 
        }
    }

    private void ShowHint()
    {
        boatHint.SetActive(true);
        StartCoroutine(GameManager.RemoveAfterSeconds(3, boatHint));
    }
}
