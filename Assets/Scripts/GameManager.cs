using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int Score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI infos;
    public GameObject firstpanel ,panel,lastpanel;
    public GameObject[] imagetarget;

    public void Start()
    {
        Score = 0;
        scoreText.text = "Score : " + Score.ToString();
        firstpanel.SetActive(true);
        panel.SetActive(false);
        lastpanel.SetActive(false);
    }

    public void firstimagetarget()
    {
        if (imagetarget[0].activeInHierarchy == true )
        {

            infos.text = "It is important to keep a distance away from one another as it helps to prevent spread of viruses ";

            panel.SetActive(true);
            Score += 10;
        }
        else
        {
            panel.SetActive(false);
        }

    }
    public void secondimagetarget()
    {
        
        if (imagetarget[1].activeInHierarchy == true)
        {

            infos.text = " It is important to put on the mask  To prevent the spread of covid 19  . keep your mask on";

            panel.SetActive(true);
            Score += 10;
        }
        else
        {
            panel.SetActive(false);
        }

    }

    public void checkfirsttarget()
    {
        if (imagetarget[1].activeInHierarchy == true)
        {
            lastpanel.SetActive(true);
        }
    }

    public void loadmenu()
    {
        SceneManager.LoadScene("menu");

    }
    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = "Score : " + Score.ToString();
    }
}
