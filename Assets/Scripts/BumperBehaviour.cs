using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperBehaviour : MonoBehaviour
{
    //The tag attached to the object hitting the bumper
    [SerializeField]
    private string _tagName;
    //The force in which the ball should bounce off
    [SerializeField]
    private float _force;
    [SerializeField]
    private int _score;
    [SerializeField]
    private int _doubleScore;
    private ScoreBehaviour _scoreBehaviour;


    public float Force
    {
        get { return _force; }
        set { _force = value; }
    }

    
    /// <summary>
    /// When object collides with the bumper, depending on direction and force 
    /// the ball has hit the bumper, will determine the amount of force needed to 
    /// actively push the ball away and in what direction.
    /// </summary>
    /// <param name="collision">The collision</param>
    private void OnCollisionEnter(Collision collision)
    {
        //If the object colliding the bumpers tag is the tag name...
        if (collision.transform.tag == _tagName)
        {
            
            
            Rigidbody ballRigidbody = collision.rigidbody;

            //Calls score behaviours add score function to add points to the players total score.
            ScoreBehaviour._instance.AddScore(_score);

            //...find the direction the ball should go in.
            Vector3 direction = (collision.transform.position - transform.position).normalized;
            //set the balls direction to always be on the x and z plane
            direction.y = 0;
            //multiply the direction and a force and add it to the balls rigidbody
            ballRigidbody.AddForce(direction * Force);
        }
    }
}
