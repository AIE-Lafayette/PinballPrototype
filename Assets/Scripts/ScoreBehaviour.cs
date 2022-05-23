using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    public GameObject Pinball;
    [SerializeField]
    public int Score;
    private int TotalScore;
    // Start is called before the first frame update
    void Start()
    {
        TotalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Ball(1)")
        {
            Score += TotalScore;
            Debug.Log("Score");
        }
    }
}
