using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBehaviour : MonoBehaviour
{
    public static ScoreBehaviour _instance;
    public GameObject Pinball;
    private int _totalScore = 0;

    public Text TotalScore;
    public Text ScoreText;
    // Start is called before the first frame update
    void Awake()
    {
        
        _instance = this;
    }

    void Start()
    {
        _totalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Displays they total score to the UI
        ScoreText.text = _totalScore.ToString();
        TotalScore.text = _totalScore.ToString();
    }

    /// <summary>
    /// Adds points to the players total score
    /// </summary>
    /// <param name="score">Points to be added to the total score</param>
    public void AddScore(int score)
    {
        _totalScore += score;
    }
}
