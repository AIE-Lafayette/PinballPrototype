using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrainFailBehaviour : MonoBehaviour
{
    public GameObject pinball;
    public Transform destination;
    public int ballCount = 3;
    public bool fail;
    public Image Image1, Image2, Image3;

    [SerializeField]
    private GameObject _gameOverScreen;


    // Update is called once per frame
    void Update()
    {
        
        if (pinball.transform.position.y < -20)
        {
            this.pinball.transform.position = destination.position;
            ballCount -= 1;
        }

        if (ballCount == 2)
        {
            Image1.enabled = false;
        }

        if (ballCount == 1)
        {
            Image2.enabled = false;
        }

        if (ballCount == 0)
        {
            _gameOverScreen.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
