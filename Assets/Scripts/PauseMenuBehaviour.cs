using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System;

public class PauseMenuBehaviour : MonoBehaviour
{
    private PauseUI _pauseUI;
    private InputAction _menu;
    [SerializeField]
    private GameObject _pauseMenu;
    private bool _isPaused;

  
    public void OnEnable()
    {
        _menu = _pauseUI.Pause.PauseButton;
        _menu.Enable();

        _menu.performed += PauseGame;
    }

    
    public void OnDisable()
    {
        _menu.Disable();
    }

    private void PauseGame(InputAction.CallbackContext context)
    {
        _isPaused = !_isPaused;

        if (_isPaused)
        {
            ActivatePauseMenu();
        }
        else
        {
            DeactivatePauseMenu();
        }
    }

    /// <summary>
    /// The time scale is set to 0 which stops time in game.
    /// Set the pause menu to be active for the canvas to appear on screen.
    /// </summary>
    private void ActivatePauseMenu()
    {
        Time.timeScale = 0;
        _pauseMenu.SetActive(true);
    }

    /// <summary>
    /// The time scale is set to be 1 which will resume the game.
    /// The pause menu is set to no longer be active which will disable the 
    /// canvas to not show on screen.
    /// </summary>
    public void DeactivatePauseMenu()
    {
        Time.timeScale = 1;
        _pauseMenu.SetActive(false);
        _isPaused = false;
    }

    
    /// <summary>
    /// Loads the main game and restarts the game completely
    /// </summary>
    public void Restart()
    {
        Time.timeScale = 1;
        ScoreBehaviour.Score = 0;
        SceneManager.LoadScene("MainScene");
    }

    /// <summary>
    /// The game closes out completely
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    /// <summary>
    /// Initialize the UI pause controls
    /// </summary>
    private void Awake()
    {
        _pauseUI = new PauseUI();
    }

}
