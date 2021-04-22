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

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
         if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.transform.gameObject.tag);
                if(hit.transform.gameObject.tag == "Boat");
                {
                    // Debug.Log("Boat");
                    ShowHint();
                    GameManager.boatClicked = true; 
                }    
            }
        }
    }

    private void ShowHint()
    {
        boatHint.SetActive(true);
        StartCoroutine(GameManager.RemoveAfterSeconds(3, boatHint));
    }
}
