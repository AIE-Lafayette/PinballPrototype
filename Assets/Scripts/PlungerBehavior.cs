using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerBehavior : MonoBehaviour
{
    private PlungerController _plunger;

    [SerializeField]
    private float _power;
    [SerializeField]
    public float _maxPower = 100f;
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

        //if a ball is the zone of the slider....
        if (_ballReady)
        {
            //... activate the power slider
            _powerSlider.gameObject.SetActive(true);
        }
        else
        {
            //else turn the power slider off
            _powerSlider.gameObject.SetActive(false);
        }

        _powerSlider.value = _power;
        //if a ball is the area of the slider....
        if (_ballList.Count > 0)
        {
            //..then ball is ready to be fired
            _ballReady = true;
            //if the space bar is held down....
            if (Input.GetKey(KeyCode.Space))
            {
                //... charge the power slider
                if (_power <= _maxPower)
                {
                    _power += 8000 * Time.deltaTime;
                }
            }
            //if the spacebar is released
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //...shoot the ball out of the slider
                foreach (Rigidbody ball in _ballList)
                {
                    ball.AddForce(_power * new Vector3(-1, 0, 0));
                }
            }
        }
        //else disable the slider
        else
        {
            _ballReady = false;
            _power = 0f;
        }
    }

    //see if the object in the area is a ball if yes then activate launcher
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }

    //if ball leaves launcher or foreign object enters then deactivate
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            _power = 0f;
        }
    }
}
