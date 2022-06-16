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

    //[SerializeField]
    //private GameObject _gameOverScreen;


    // Update is called once per frame
    void Update()
    {
        //If the ball falls below -20 on the y the ball will respawn at the given position also will decrement ball count by 1
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
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
