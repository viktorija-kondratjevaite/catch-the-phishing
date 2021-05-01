using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatClicker : MonoBehaviour {
    public GameObject boatHint; 
    
    void Start() {
        boatHint.SetActive(false);
    }

    void FixedUpdate() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Input.GetMouseButtonDown(0)) {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
                if (hit.transform.gameObject.tag == "Boat") {
                    ShowHint();
                    GameManager.boatClicked = true; 
                    GameManager.currentTask = GameManager.CHEST;
                }    
            }
        }
    }

    private void ShowHint() {
        boatHint.SetActive(true);
        StartCoroutine(GameManager.RemoveAfterSeconds(3, boatHint));
    }
}
