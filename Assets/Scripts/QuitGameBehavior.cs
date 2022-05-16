using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
