using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartLevel(int levelNumber)
    {
        SceneManager.LoadScene(levelNumber);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
