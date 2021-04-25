using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunflowerClicker : MonoBehaviour
{
    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0) && GameManager.rockClicked == true && ThirdTask.thirdTaskDone == false)
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.tag == "Sunflower")
                {
                    Application.LoadLevelAsync("ThirdTask");
                    GameManager.sunflowerClicked = true;
                }    
            }
        }
    }
}
