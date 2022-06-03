using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehaviour : MonoBehaviour
{
    public GameObject Pinball;
    [SerializeField]
    public int Score;
    private int TotalScore;

    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        TotalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreText.text = TotalScore.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Pinball")
        {
            Score += TotalScore;
            ScoreText.text = TotalScore.ToString();
            Debug.Log("Score");
        }
        
    }
}
