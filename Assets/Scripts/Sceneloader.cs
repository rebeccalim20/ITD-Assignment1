using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{

    // Start is called before the first frame update

    private void Awake()
    {

    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");

    }
    public void firstscene()
    {
        SceneManager.LoadScene("firstscene");
        
    }
    public void loadquestion1 ()
    {
        SceneManager.LoadScene("Question 1");
    }
    public void loadquestion2()
    {
        SceneManager.LoadScene("Question 2");
    }
    public void loadquestion3()
    {
        SceneManager.LoadScene("Question 3");
    }
    public void loadquestion4()
    {
        SceneManager.LoadScene("Question 4");
    }

    public void inventoryfeature()
    {
        SceneManager.LoadScene("InventoryFeature");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
