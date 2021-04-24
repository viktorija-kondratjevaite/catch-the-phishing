using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestClicker : MonoBehaviour
{
    public GameObject chestHint;

    void Start()
    {
        chestHint.SetActive(false);
    }

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && GameManager.boatClicked == true)
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.tag == "Chest")
                {
                    ShowHint();
                    GameManager.chestClicked = true;
                }    
            }
        }
        if (Input.GetMouseButtonDown(1) && GameManager.boatClicked == true)
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.tag == "Chest")
                {
                    Application.LoadLevelAsync("CodeInput");
                }    
            }
        }
    }

    private void ShowHint()
    {
        chestHint.SetActive(true);
        StartCoroutine(GameManager.RemoveAfterSeconds(4, chestHint));
    }
}
