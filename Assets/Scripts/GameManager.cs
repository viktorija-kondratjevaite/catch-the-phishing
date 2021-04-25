using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static bool boatClicked = false; 
    public static bool chestClicked = false; 
    public static bool mushroomClicked = false; 
    public static bool rockClicked = false;
    public static bool sunflowerClicked = false; 
    public static bool campfireClicked =false;
    
     public static IEnumerator RemoveAfterSeconds(int seconds, GameObject obj) 
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
    
    public static void ComeBackToIsland()
    {
        SceneManager.LoadSceneAsync("Island");
    }
}
