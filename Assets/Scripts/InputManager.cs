using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    public GameObject inputField;
    public GameObject wrongCodeMessage;
    private string code = "8469";
    private string input;

    public void Start()
    {
        wrongCodeMessage.SetActive(false);
    }

   public void ValidateInput()
   {
       input = inputField.GetComponent<Text>().text;
       if (input != code)
       {
           wrongCodeMessage.SetActive(true);
           StartCoroutine(GameManager.RemoveAfterSeconds(5, wrongCodeMessage));
       }
       else
       SceneManager.LoadSceneAsync("Island");
   }
}
