using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehaviour : MonoBehaviour
{
    public static ScoreBehaviour _instance;
    public GameObject Pinball;
    private int TotalScore;

    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        TotalScore = 0;
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //Displays they total score to the UI
        ScoreText.text = TotalScore.ToString();
    }

    /// <summary>
    /// Adds points to the players total score
    /// </summary>
    /// <param name="score">Points to be added to the total score</param>
    public void AddScore(int score)
    {
        if (MaterialChangeBehavior.isMultiplyerActive)
            score *= 2;

        TotalScore += score;
        ScoreText.text = TotalScore.ToString();
    }

    




}
