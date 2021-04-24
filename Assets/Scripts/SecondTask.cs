using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTask : MonoBehaviour
{
    public GameObject firstTask;
    public GameObject secondTask;
    public GameObject thirdTask;
    public GameObject help;
    public GameObject wrongAnswer;
    public GameObject finishedTask;
    private bool answerIncorrect;
    private int answeredCorrectly = 0; 
    
    public void Start()
    {
        firstTask.SetActive(true);
        secondTask.SetActive(false);
        thirdTask.SetActive(false);
        help.SetActive(false);
        finishedTask.SetActive(false);
        wrongAnswer.SetActive(false);
        answerIncorrect = false; 
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
                secondTask.SetActive(false);
                thirdTask.SetActive(true);
                break;
                case 3: 
                thirdTask.SetActive(false);
                finishedTask.SetActive(true);
                break;
            }
            
    }

    public void IncorrectAnswer()
    {
        answerIncorrect = true;
        Help();
    }

    public void Help()
    {
        help.SetActive(true);
        if(answerIncorrect == true)
        {
            wrongAnswer.SetActive(true);
            answerIncorrect = false;
        }
    }

    public void Continue()
    {
        help.SetActive(false);
        wrongAnswer.SetActive(false);
    }

    public void ChangeScene()
    {
        GameManager.ComeBackToIsland();
    }
}
