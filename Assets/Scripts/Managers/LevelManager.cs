using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Menu menu;
    [SerializeField] private FinishMenu finishMenu;
    [SerializeField] private TimerText timerText;

    private float startTime = 0f;
    private bool finished = false;

    private void Start()
    {
        startTime = Time.time;
        menu.Close();
        finishMenu.Close();
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (MenuButtonPressed())
        {
            OnMenuButtonPressed();
        }
        timerText.SetTime(Time.time - startTime);
    }

    public void OnCheckpointEnter()
    {
        OpenFinishMenu();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private bool MenuButtonPressed()
    {
        return Input.GetKeyDown(KeyCode.Escape) || Input.GetKey(KeyCode.JoystickButton9);
    }

    private void OnMenuButtonPressed()
    {
        if (menu.isActive())
        {
            CloseMenu();
        } else
        {
            OpenMenu();
        }
    }

    private void OpenMenu()
    {
        if (finished) return;
        Time.timeScale = 0f;
        menu.Open();
    }

    private void CloseMenu()
    {
        if (finished) return;
        Time.timeScale = 1f;
        menu.Close();
    }

    private void OpenFinishMenu()
    {
        finished = true;
        Time.timeScale = 0f;
        float finishTime = Time.time - startTime;
        finishMenu.Open(finishTime);
    }

    private void CloseFinishMenu()
    {
        Time.timeScale = 1f;
        finishMenu.Close();
    }
}
