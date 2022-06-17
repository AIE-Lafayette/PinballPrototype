using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterBehaviour : MonoBehaviour
{
    [SerializeField]
    private string _tagName;

    public GameObject pinball;
    public Transform destination;

    // Update is called once per frame
    void Update()
    {
       
    }
    //On colision will rest the objects position to the given destination
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == _tagName)
        {
            this.pinball.transform.position = destination.position;
        }
    }
}
