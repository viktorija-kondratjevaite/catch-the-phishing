using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireClicker : MonoBehaviour
{
    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0) && GameManager.sunflowerClicked == true && FourthTask.fourthTaskDone == false)
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.tag == "Campfire")
                {
                    Application.LoadLevelAsync("FourthTask");
                    GameManager.campfireClicked = true;
                }    
            }
        }
    }
}
