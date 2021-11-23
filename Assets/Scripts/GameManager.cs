using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("This is for the firstimg when scan")]
    public GameObject imgdistance;
    [Tooltip("This is for the firstimgbutton when scan")]
    public GameObject imgdistancebtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (imgdistance.activeInHierarchy == true)
        {
            imgdistancebtn.SetActive(true);
        }
        else
        {
            imgdistancebtn.SetActive(false);
        }
    }
}
