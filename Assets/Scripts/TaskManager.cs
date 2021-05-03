using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour {
    public bool isLastTask;
    public string nextTask;
    public GameObject firstTask;
    public GameObject secondTask;
    public GameObject thirdTask;
    public GameObject help;
    public GameObject wrongAnswer;
    public GameObject finishedTask;
    public GameObject? explanationOnSelfSSL = null;
    private bool answerIncorrect = false;
    private int answeredCorrectly = 0; 
    
    public void Start() {
        firstTask.SetActive(true);
        secondTask.SetActive(false);
        thirdTask.SetActive(false);
        help.SetActive(false);
        finishedTask.SetActive(false);
        wrongAnswer.SetActive(false);
    }

    public void CorrectAnswer() {
        answeredCorrectly++;

        switch(answeredCorrectly) {
            case 1: 
                firstTask.SetActive(false);
                secondTask.SetActive(true);
                break;
            case 2: 
                if(explanationOnSelfSSL == null) {
                    secondTask.SetActive(false);
                    thirdTask.SetActive(true);
                } else {
                    ExplainSelfSSL();
                }
                break;
            case 3: 
                thirdTask.SetActive(false);
                finishedTask.SetActive(true);
                Debug.Log(nextTask);
                GameManager.currentTask = nextTask;
                GameManager.chestCodeAcquired = isLastTask;
                break;
        }
    }

    public void ExplainSelfSSL() {
        explanationOnSelfSSL.SetActive(true);
    }

    public void ContinueFromExplanation() {
        explanationOnSelfSSL.SetActive(false);
        secondTask.SetActive(false);
        thirdTask.SetActive(true);
    }

    public void IncorrectAnswer(bool thirdTask) {
        if(thirdTask) {
            wrongAnswer.SetActive(true);
            StartCoroutine(GameManager.RemoveAfterSeconds(2, wrongAnswer));
        } else {
            answerIncorrect = true;
            Help(thirdTask);
        }
    }

    public void Help(bool thirdTask) {
        help.SetActive(true);

        if(answerIncorrect == true && !thirdTask) {
            wrongAnswer.SetActive(true);
            answerIncorrect = false;
        }
    }

    public void Continue(bool thirdTask) {
        help.SetActive(false);
        
        if(!thirdTask)
            wrongAnswer.SetActive(false);
    }

    public void changeScene() {
        GameManager.ComeBackToIsland();
    }
}
