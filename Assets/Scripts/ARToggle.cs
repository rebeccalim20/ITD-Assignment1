using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARToggle : MonoBehaviour
{
    public GameObject astronaut;

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
            astronaut.SetActive(false);
        }
        else
        {
            VuforiaBehaviour.Instance.enabled = true;
            astronaut.SetActive(true);
        }
    }
}
