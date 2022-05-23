using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _pauseMenu;
    private bool _isPaused;

    /// <summary>
    /// The pause menu is activated and time has stopped.
    /// </summary>
    public void ActivateMenu()
    {
        //Game is paused
        _pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    /// <summary>
    /// The pause menu is no longer active and time as resumed.
    /// </summary>
    public void DeactivateMenu()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    /// <summary>
    /// Loads the main game and restarts the game completely
    /// </summary>
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// The game closes out completely
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.P))
        //{
        //    _isPaused = true;
        //}

        if (_isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }
}
