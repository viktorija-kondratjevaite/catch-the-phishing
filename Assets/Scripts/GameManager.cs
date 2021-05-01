using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public const string BOAT = "BOAT";
    public const string MUSHROOM = "MUSHROOM";
    public const string CHEST = "CHEST";
    public const string SUNFLOWER = "SUNFLOWER";
    public const string ROCK = "ROCK";
    public const string CAMPFIRE = "CAMPFIRE";

    public static bool boatClicked = false; 
    public static bool chestClicked = false; 
    public static bool mushroomClicked = false; 
    public static bool rockClicked = false;
    public static bool sunflowerClicked = false; 
    public static bool campfireClicked =false;
    public static bool firstTaskDone = false;
    public static bool secondTaskDone = false; 
    public static bool thirdTaskDone = false; 
    public static bool fourthTaskDone = false;
    public static bool codeInputCorrect = false; // TODO add to code input script
    public static bool chestCodeAcquired = false; 

    public static string currentTask = BOAT;
    
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
