using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuizManager : MonoBehaviour
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
        questionTitle.text = "How is Covid-19 transmitted?";
        answerOne.text = "Droplets or aerosols. \n When an infected person coughs, sneezes or talks.";
        answerTwo.text = "Airborne transmission \n If you breathe in the air an infected person breathes out. \n The Virus can also live in the air for up to 3 hours.";
        answerThree.text = "Surface transmission \n When you touch surfaces that an infected person has interacted with.";
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
        /*QuestionOne.gameObject.SetActive(false);*/
        SceneManager.LoadScene("Question 2");
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
