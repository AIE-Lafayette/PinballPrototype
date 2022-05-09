using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongboatBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private float _timer;

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        _timer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        transform.Translate(transform.forward * Time.deltaTime * Speed);

        if (_timer <= 0)
            Destroy(this);
    }
}
