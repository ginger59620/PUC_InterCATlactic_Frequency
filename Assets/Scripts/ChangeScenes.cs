using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.VisualScripting.Member;

public class ChangeScenes : MonoBehaviour
{
    public void MainMenu()
    {
      
            SceneManager.LoadScene("MainMenu");
        
    }

    public void ModeSelector()
    {

        SceneManager.LoadScene("ModeSelector");
    }

    public void StoryMode()
    {

        SceneManager.LoadScene("StoryMode");
    }

    public void FreeMode()
    {

        SceneManager.LoadScene("FreeMode");
    }

    public void SMsongSelector()
    {

        SceneManager.LoadScene("SMsongSelector");
    }

}
