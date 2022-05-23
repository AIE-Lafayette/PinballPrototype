using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehaviorScript : MonoBehaviour
{
    private PaddleControls _paddleControls;

    [SerializeField]
    private float _restPosition = 0f;
    [SerializeField]
    private float _pressedPosition = 45f;
    [SerializeField]
    private float _hitStrength = 10000f;
    [SerializeField]
    private float _flipperDamper = 150f;

    public string _inputName;
    HingeJoint _hinge;


    private void Awake()
    {
        _paddleControls = new PaddleControls();
    }

    private void OnEnable()
    {
        _paddleControls.Enable();
    }

    private void OnDisable()
    {
        _paddleControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        _hinge = GetComponent<HingeJoint>();
        _hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
       


        JointSpring spring = new JointSpring();
        spring.spring = _hitStrength;
        spring.damper = _flipperDamper;

        if (Input.GetAxis(_inputName) == 1)
        {
            spring.targetPosition = _pressedPosition;
        }
        else
        {
            spring.targetPosition = _restPosition;
        }
        _hinge.spring = spring;
        _hinge.useLimits = true;

        
    }

   
}
