using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestClicker : MonoBehaviour
{
    public GameObject chestHint;

    void Start()
    {
        chestHint.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.boatClicked == true) 
            ShowHint();
        if (Input.GetMouseButtonDown(0))
        Debug.Log(GameManager.boatClicked);
    }

    private void ShowHint()
    {
        chestHint.SetActive(true);
        StartCoroutine(GameManager.RemoveAfterSeconds(3, chestHint));
    }
}
