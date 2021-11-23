using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionFour : MonoBehaviour
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
        questionTitle.text = "What is the eligible age for children to book their first vaccination appointment?";
        answerOne.text = "12 years old";
        answerTwo.text = "13 years old";
        answerThree.text = "18 years old";
        answerFour.text = "21 years old";
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
