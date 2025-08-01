using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private float _timer = 2f;
    [SerializeField] private PlayerColorController _playerColor;

    public Action _onTimerChange;
    public IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timer);
            _onTimerChange += _playerColor.ChangeColor;
            _onTimerChange.Invoke(); 
        }
    }

    private void Start()
    {
        StartCoroutine(Timer());
    }


}
