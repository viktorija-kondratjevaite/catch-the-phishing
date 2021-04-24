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
    // public static GameObject player;
    // public static float x; 
    // public static float y;
    // public static float z;  
    // public static void Start()
    // {
    //     Cursor.lockState = CursorLockMode.Confined;
    // }

     public static IEnumerator RemoveAfterSeconds(int seconds, GameObject obj) 
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
    
    public static void ComeBackToIsland()
    {
        SceneManager.LoadSceneAsync("Island");
    }
    // public static void SaveCoordinates() 
    // {
    //     player = GameObject.Find("Player");
    //     PlayerPrefs.SetFloat("X", player.transform.position.x);
    //     PlayerPrefs.SetFloat("Y", player.transform.position.y);
    //     PlayerPrefs.SetFloat("Z", player.transform.position.z);
       
    // }
    // public static void PlayerIsComingBack (){
    //    // Player comes back
    //     player.transform.position.x = PlayerPrefs.GetFloat("X");
    //     player.transform.position.y = PlayerPrefs.GetFloat("Y");
    //     player.transform.position.z = PlayerPrefs.GetFloat("Z");
    // }
}
