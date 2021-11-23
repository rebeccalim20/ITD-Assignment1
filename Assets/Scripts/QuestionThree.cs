using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionThree : MonoBehaviour
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
        questionTitle.text = "What are some things you can do to keep yourself safe from Covid-19?";
        answerOne.text = "Wearing masks in crowded areas.";
        answerTwo.text = "Practise Social Distancing.";
        answerThree.text = "Sanitising your hands regularly";
        answerFour.text = "All of the above";
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
