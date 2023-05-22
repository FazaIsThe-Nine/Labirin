using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Easy() 
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Medium() 
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Hard() 
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Quit () 
    {
        Application.Quit();
    }
}
