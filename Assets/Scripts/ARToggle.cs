using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARToggle : MonoBehaviour
{
    public List<GameObject> models;
    /*private int currentActiveIndex;*/

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
        
    }
}
