using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongBoatBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * Speed); 
        
    }
}
