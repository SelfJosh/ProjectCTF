using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
   public void characterSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void settingsButton()
    {
        
    }

    public void quitButton()
    {
        Application.Quit();
    }
}
