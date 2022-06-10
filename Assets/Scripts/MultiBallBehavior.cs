using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBallBehavior : MonoBehaviour
{
    public static bool isMultiBallActive = false;
    public Material[] _material;
    private Renderer _render;
    private Collider _collider;
    

    // Start is called before the first frame update
    void Start()
    {
        _render = GetComponent<Renderer>();
        _render.enabled = true;
        _render.sharedMaterial = _material[0];
        _collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isMultiBallActive)
            return;

        _render.sharedMaterial = _material[1];
        isMultiBallActive = true;
        _collider.enabled = false;

        TimerBehaviour.Instance.StartNewTimedAction(args => { _render.sharedMaterial = _material[0]; isMultiBallActive = false; _collider.enabled = true; },
            TimedActionCountType.SCALEDTIME, 15.0f);

    }

    private void SpawnBall()
    {

    }
}
