using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBehaviour : MonoBehaviour
{
    public static ScoreBehaviour _instance;
    public GameObject Pinball;

    public Text ScoreText;

    public static int Score;

    //Start is called before the first frame update
    void Awake()
    {

        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //Displays they total score to the UI
        ScoreText.text = Score.ToString();
    }

    /// <summary>
    /// Adds points to the players total score
    /// </summary>
    /// <param name="score">Points to be added to the total score</param>
    public void AddScore(int score)
    {
        if (MaterialChangeBehavior.isMultiplyerActive)
            score *= 2;

        Score += score;
        ScoreText.text = Score.ToString();
    }

    




}
