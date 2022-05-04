using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrainFailBehaviour : MonoBehaviour
{
    public GameObject pinball;
    public Transform destination;
    public int ballCount = 3;
    public bool fail;

    // Update is called once per frame
    void Update()
    {
        if (pinball.transform.position.y < -10)
        {
            this.pinball.transform.position = destination.position;
            ballCount -= 1;
        }
    }
}
