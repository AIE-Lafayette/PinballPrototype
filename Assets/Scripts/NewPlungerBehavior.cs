using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlungerBehavior : MonoBehaviour
{
	private PlungerController _plunger;
	[SerializeField]
	private float _distance = 50;
	[SerializeField]
	private float _speed = 1;
	[SerializeField]
	public GameObject _ball;

	

	private bool _ready = false;
	private bool _fire = false;
	private float _moveCount = 0;

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Ball")
		{
			_ready = true;
		}
	}

	private void Update()
	{
		Vector2 plunger = _plunger.Charge.pullback.ReadValue<Vector2>();


		if (_plunger.Charge.pullback.triggered)
		{
			if (_moveCount < _distance)
			{
				transform.Translate(0, 0, -_speed * Time.deltaTime);
				_moveCount += _speed * Time.deltaTime;
				_fire = true;
			}
		}
		else if (_moveCount > 0)
		{
			if (_fire && _ready)
			{
				_ball.transform.TransformDirection(Vector3.forward * 10);
				
			}
		}
	}

}
