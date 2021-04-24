using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockClicker : MonoBehaviour
{
    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && GameManager.mushroomClicked == true)
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.tag == "Rock")
                {
                    Application.LoadLevelAsync("SecondTask");
                    GameManager.rockClicked = true;
                }    
            }
        }
    }
}
