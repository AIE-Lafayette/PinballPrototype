using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongboatBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    GameObject _longboat;
    [SerializeField]
    private string _tagName;
    [SerializeField]
    private float _timeToDespawn;

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _timeToDespawn);
    }

    // Update is called once per frame
    void Update()
    {
        //Longboat moves in one direction. From left to right.
        transform.Translate(transform.forward * Time.deltaTime * Speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == _tagName)
        {
            Destroy(gameObject);
        }
    }
}
