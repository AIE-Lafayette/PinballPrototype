using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoveBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 _velocity;

    public Vector3 Velocity
    {
        get { return _velocity; }
        set { _velocity = value; }
    }
    
    /// <summary>
    /// Adds velocity to the objects given position
    /// </summary>
    public void FixedUpdate()
    {
        transform.position += _velocity * Time.deltaTime;
    }
}
