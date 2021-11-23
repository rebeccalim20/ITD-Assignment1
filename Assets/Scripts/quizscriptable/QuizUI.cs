using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private QuizsManager quizsManager;               //ref to the QuizManager script
    [SerializeField] private TextMeshProUGUI questionText;                 //text to show question
    /*[SerializeField] private Text scoreText, timerText;*/
   /* [SerializeField] private GameObject gameOverPanel, mainMenu, gamePanel;*/
    [SerializeField] private Color correctCol, wrongCol, normalCol; //color of buttons       
    [SerializeField] private List<Button> options;                  //options button reference
    private bool answered;      //bool to keep track if answered or not
    private Question question; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetQuestion (Question question)
    {
        this.question = question;
        questionText.text = question.questionInfo;

        List<string> answerList = ShuffleList.ShuffleListItems<string>(question.options);
        for (int i = 0; i < options.Count; i++)
        {
            //set the child text
            options[i].GetComponentInChildren<Text>().text = answerList[i];
            options[i].name = answerList[i];    //set the name of button
            options[i].image.color = normalCol; //set color of button to normal
        }

        answered = false;
    }
}
