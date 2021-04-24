using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTask : MonoBehaviour
{
    public static bool thirdTaskDone = false;

    public GameObject firstTask;
    public GameObject secondTask;
    public GameObject thirdTask;
    public GameObject help;
    public GameObject wrongAnswer;
    public GameObject finishedTask;
    public GameObject explanationOnSelfSSL;
    private int answeredCorrectly = 0; 
    
    public void Start()
    {
        firstTask.SetActive(true);
        secondTask.SetActive(false);
        thirdTask.SetActive(false);
        help.SetActive(false);
        finishedTask.SetActive(false);
        wrongAnswer.SetActive(false);
        explanationOnSelfSSL.SetActive(false);
    }

    public void CorrectAnswer()
    {
        answeredCorrectly++;
        switch(answeredCorrectly)
            {
                case 1: 
                firstTask.SetActive(false);
                secondTask.SetActive(true);
                break;
                case 2: 
                ExplainSelfSSL();
                break;
                case 3: 
                thirdTask.SetActive(false);
                finishedTask.SetActive(true);
                thirdTaskDone = true;
                break;
            }
            
    }

    public void ExplainSelfSSL()
    {
        explanationOnSelfSSL.SetActive(true);
    }

    public void ContinueFromExplanation()
    {
        explanationOnSelfSSL.SetActive(false);
        secondTask.SetActive(false);
        thirdTask.SetActive(true);
    }

    public void IncorrectAnswer()
    {
        wrongAnswer.SetActive(true);
        StartCoroutine(GameManager.RemoveAfterSeconds(2, wrongAnswer));
    }

    public void Help()
    {
        help.SetActive(true);
    }

    public void Continue()
    {
        help.SetActive(false);
    }

    public void ChangeScene()
    {
        GameManager.ComeBackToIsland();
    }
}
