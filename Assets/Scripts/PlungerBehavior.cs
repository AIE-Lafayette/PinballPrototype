using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerBehavior : MonoBehaviour
{
    [SerializeField]
    private float _power;
    [SerializeField]
    public float _maxPower = 100f;
    [SerializeField]
    private float _minPower = 0f;
    public Slider _powerSlider;
    List<Rigidbody> _ballList;
    private bool _ballReady;

    // Start is called before the first frame update
    void Start()
    {
        _powerSlider.minValue = 0f;
        _powerSlider.maxValue = _maxPower;
        _ballList = new List<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_ballReady)
        {
            _powerSlider.gameObject.SetActive(true);
        }
        else
        {
            _powerSlider.gameObject.SetActive(false);
        }

        _powerSlider.value = _power;
        if (_ballList.Count > 0)
        {
            _ballReady = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if (_power <= _maxPower)
                {
                    _power += 50 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach (Rigidbody ball in _ballList)
                {
                    ball.AddForce(_power * Vector3.forward);
                }
            }
        }
        else
        {
            _ballReady = false;
            _power = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            _power = 0f;
        }
    }
}
