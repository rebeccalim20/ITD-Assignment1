using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //[Tooltip("This is for the firstimg when scan")]
    //public GameObject imgdistance;
    //[Tooltip("This is for the firstimgbutton when scan")]
    //public GameObject imgdistancebtn;
    // Start is called before the first frame update

    public GameObject[] imgtargets;
    private int currentScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI infos;
    public GameObject panel;

    public void Start()
    {
        currentScore = 0;
       

    }
    public void imagestargets()
    {

        if (imgtargets[0].activeInHierarchy == true)
        {
            infos.text = "It is important to keep a distance away from one another as it helps to prevent spread of viruses ";
            Debug.Log("yeaasd");
            panel.SetActive(true);
        }

        if (imgtargets[1].activeInHierarchy == true)
        {
            infos.text = "It is important to keep a distance away from one another as it helps to prevent spread of viruses ";
            
            panel.SetActive(true);
        }

        else
        {
            panel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        imagestargets();
        //if (imgdistance.activeInHierarchy == true)
        //{
        //    imgdistancebtn.SetActive(true);
        //}
        //else
        //{
        //    imgdistancebtn.SetActive(false);
        //}
    }
}
