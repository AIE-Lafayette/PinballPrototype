using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChangeBehavior : MonoBehaviour
{
    public Material[] _material;
    private Renderer _render;

    // Start is called before the first frame update
    void Start()
    {
        _render = GetComponent<Renderer>();
        _render.enabled = true;
        _render.sharedMaterial = _material[0];
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            _render.sharedMaterial = _material[1];
        }
    }
}
