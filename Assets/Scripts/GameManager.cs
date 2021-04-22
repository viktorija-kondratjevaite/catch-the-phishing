using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public static bool boatClicked = false; 
    public static bool chestClicked = false; 

     public static IEnumerator RemoveAfterSeconds(int seconds, GameObject obj) 
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
}
