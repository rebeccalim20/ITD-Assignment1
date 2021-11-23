using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchTracker : MonoBehaviour
{
    private Touch firstTouch;
    public Text debugText;
    public GameObject astronautbutton;

    //rotate gameobject 
    public GameObject rotateGo;
    public float rotatespeed;
    public bool rotatestatus = false;

    //astronaut 3d go
    public GameObject descriptionastronaut;
    public bool descripstatus = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Rotate()
    {
        if(rotatestatus ==false)
        {
            rotatestatus = true;
        }
        else
        {
            rotatestatus = false;
        }
    }
    public void updatestatusrotate()
    {
        if(rotatestatus ==true)
        {
            rotateGo.transform.Rotate(Vector3.up , rotatespeed * Time.deltaTime);
        }
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
                
                if (info.collider.tag == "Astronaut")
                {
                    if (descripstatus == false)
                    {
                        descriptionastronaut.SetActive(true);
                        descripstatus = true;
                    }
                    else
                    {
                        descripstatus = false;
                        descriptionastronaut.SetActive(false);
                    }

                }
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
        updatestatusrotate();
        StoreTouches();
    }
}
