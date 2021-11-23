using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionTwo : MonoBehaviour
{
    public GameObject QuestionOne;
    public Button answerOneButton;
    public Button answerTwoButton;
    public Button answerThreeButton;
    public Button answerFourButton;
    public Text questionTitle;


    public Text answerOne;
    public Text answerTwo;
    public Text answerThree;
    public Text answerFour;

    public GameObject wrongAnswerPopUp;
    public GameObject correctAnswerPopUp;


    public void QuizProcess()
    {
        questionTitle.text = "How can you tell if someone has Covid-19?";
        answerOne.text = "You can never be too sure \n some people do not get symptoms even when they have Covid-19.";
        answerTwo.text = "If the person is coughing and sneezing a lot.";
        answerThree.text = "If someone has a fever and feels like they have lost their sense of smell.";
        answerFour.text = "All of the above.";
    }

    
    public void WrongAnswerPopUp()
    {
        wrongAnswerPopUp.gameObject.SetActive(true);
    }

    public void CorrectAnswerPopUp()
    {
        correctAnswerPopUp.gameObject.SetActive(true);
    }

    public void ExitButtonForDone()
    {
        QuestionOne.gameObject.SetActive(false);
    }

    public void TryQuestionAgainButton()
    {
        wrongAnswerPopUp.gameObject.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
    
    }

// Update is called once per frame
    void Update()
    {
       QuizProcess();
    }
}
