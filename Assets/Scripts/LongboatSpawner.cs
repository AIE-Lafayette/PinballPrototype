using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongboatSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _longboat;
    private TimerBehaviour.TimedAction _currentAction;

    // Start is called before the first frame update
    void Start()
    {
        _currentAction = new TimerBehaviour.TimedAction();
    }


    // Update is called once per frame
    void Update()
    {
        if (!_currentAction.IsActive)
        {
            _currentAction = TimerBehaviour.Instance.StartNewTimedAction(args => Instantiate(_longboat, transform.position, transform.rotation), TimedActionCountType.SCALEDTIME, 8);
            
        }
    }
}

