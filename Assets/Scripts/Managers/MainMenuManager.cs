using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartLevel(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1: SceneManager.LoadScene(1); break;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
