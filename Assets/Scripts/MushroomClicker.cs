using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomClicker : MonoBehaviour
{
    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && GameManager.chestClicked == true && FirstTask.firstTaskDone == false)
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.tag == "Mushroom")
                {
                    Application.LoadLevelAsync("FirstTask");
                    GameManager.mushroomClicked = true;
                }    
            }
        }
    }
}
