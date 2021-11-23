using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARToggle : MonoBehaviour
{
    public List<GameObject> models;
    public GameObject astronaut;
    public GameObject astronautbtn;
    /*private int currentActiveIndex;*/


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void ToggleAR()
    {
        if (VuforiaBehaviour.Instance.enabled)
        {
            VuforiaBehaviour.Instance.enabled = false;

            foreach (GameObject obj in models)
            {
                obj.SetActive(false);
            }
        }

        else
        {
            VuforiaBehaviour.Instance.enabled = true;
   

        }
    }
    public void Update()
    {
        if (astronaut.activeInHierarchy == true)
        {
            astronautbtn.SetActive(true);
            Debug.Log("yesdfushfdasdasd");
        }
        else
        {
            astronautbtn.SetActive(false);
        }
    }
}
