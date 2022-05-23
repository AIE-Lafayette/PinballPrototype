using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideLauncherBehavior : MonoBehaviour
{
    [SerializeField]
    public Transform _spawnPoint;
    [SerializeField]
    public GameObject _prefab;
    private TimerBehaviour.TimedAction _currentAction;

   

    void Start()
    {
        _currentAction = new TimerBehaviour.TimedAction();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (!_currentAction.IsActive)
        {
            _currentAction = TimerBehaviour.Instance.StartNewTimedAction(args => Instantiate(_prefab, transform.position, transform.rotation), TimedActionCountType.SCALEDTIME, 1);

        }

    }

    //private void Update()
    //{
    //    if (!_currentAction.IsActive)
    //    {
    //        _currentAction = TimerBehaviour.Instance.StartNewTimedAction(args => Instantiate(_prefab, transform.position, transform.rotation), TimedActionCountType.SCALEDTIME, 3);

    //    }
    //}
}
