using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizsManager : MonoBehaviour
{
    [SerializeField] private QuizUI quizui;
    [SerializeField]
    private List<Question> questions;//questions data

    private Question selectedQuetion;    //current question data
    // Start is called before the first frame update
    void Start()
    {
        SelectQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectQuestion()
    {
        int val = Random.Range(0, questions.Count);
        selectedQuetion = questions[val];
        quizui.SetQuestion(selectedQuetion);
    }
    /// <summary>
    /// Method called to check the answer is correct or not
    /// </summary>
    /// <param name="selectedOption">answer string</param>
    /// <returns></returns>
    public bool Answer(string selectedOption)
    {
        //set default to false
        bool correctAns = false;
        //if selected answer is similar to the correctAns
        if (selectedQuetion.correctAns == selectedOption)
        {
            //Yes, Ans is correct
           
            correctAns = true;
        }
        else
        {
            //Not correct ans
        }
        Invoke("SlectedQuestion", 0.4f);
        return correctAns;
    }

}
[System.Serializable]
public class Question
{
    public string questionInfo;         //question text
    public List<string> options;        //options to select
    public string correctAns;           //correct option
}
