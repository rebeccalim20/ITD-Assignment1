using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuizManager : MonoBehaviour
{
    public Button answerOneButton;
    public Button answerTwoButton;
    public Button answerThreeButton;
    public Button answerFourButton;
    public TextMeshProUGUI questionTitle;
    public int quizQuestionPart;
    public int questionOneAnswerTrigger;
    public int questionTwoAnswerTrigger;
    public int questionThreeAnswerTrigger;
    public int questionFourAnswerTrigger;

    public TextMeshProUGUI answerOne;
    public TextMeshProUGUI answerTwo;
    public TextMeshProUGUI answerThree;
    public TextMeshProUGUI answerFour;

    public GameObject wrongAnswerPopUp;
    public GameObject correctAnswerPopUp;


    public void QuizProcess()
    {
        if (quizQuestionPart == 1)
        {
            questionTitle.text = "How is Covid-19 transmitted?";
            answerOne.text = "Droplets or aerosols. \n When an infected person coughs, sneezes or talks.";
            answerTwo.text = "Airborne transmission \n If you breathe in the air an infected person breathes out. \n The Virus can also live in the air for up to 3 hours";
            answerThree.text = "Surface transmission \n When you touch surfaces that an infected person has interacted with";
            answerFour.text = "All of the above";



        }
        else if (quizQuestionPart == 2)
        {
            questionTitle.text = "How can you tell if someone has Covid-19?";
            answerOne.text = "";
            answerTwo.text = "";
            answerThree.text = "";
            answerFour.text = "";
        }
        else if (quizQuestionPart == 3)
        {
            questionTitle.text = "What are some things you can do to keep yourself safe from Covid-19?";
            answerOne.text = "";
            answerTwo.text = "";
            answerThree.text = "";
            answerFour.text = "";
        }
        else if (quizQuestionPart == 4)
        {
            questionTitle.text = "What are some symptomps of Covid-19?";
            answerOne.text = "";
            answerTwo.text = "";
            answerThree.text = "";
            answerFour.text = "";
        }
    }
    
    public void WrongAnswerPopUp()
    {

    }

    public void CorrectAnswerPopUp()
    {

    }

    public void CorrectAnswerTriggerOne()
    {
        questionOneAnswerTrigger = 1;
    }

    public void CorrectAnswerTriggerTwo()
    {
        questionTwoAnswerTrigger = 1;
    }

    public void CorrectAnswerTriggerThree()
    {
        questionThreeAnswerTrigger = 1;
    }

    public void CorrectAnswerTriggerFour()
    {
        questionFourAnswerTrigger = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        quizQuestionPart = 0;
    }

    // Update is called once per frame
    void Update()
    {
        QuizProcess();
    }
}
