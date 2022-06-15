using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBehavior : MonoBehaviour
{
    public GameObject _mainMenu;

    private void Start()
    {
        
    }
    //Loads scene once the play button is pressed
    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CadeTestScene");
    }

    public void QuitGame()
    {
        Application.Quit();

       
    }

    
}
