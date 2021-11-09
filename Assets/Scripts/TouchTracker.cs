using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchTracker : MonoBehaviour
{
    private Touch firstTouch;
    public Text debugText;
    public GameObject astronautbutton;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void StoreTouches()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit info;

            if (Physics.Raycast(ray, out info))
            {
                
                debugText.text = "First touch at " + Input.mousePosition + "hit an object " + info.collider.name;
            }

            if (info.collider.name == "Astronaut")
            {
                Debug.Log("hitastronauts");
                astronautbutton.SetActive(true);
            }



            else
            {
                return;
            }
        }
        if (Input.touchCount > 0)
        {
            firstTouch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(firstTouch.position);
            RaycastHit info;

            if (Physics.Raycast(ray, out info))
            {
                debugText.text = "First touch at " + firstTouch.position + "hit an object " + info.collider.name;
            }

            else
            {
                return;
            }

        }
        else
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        StoreTouches();
    }
}
