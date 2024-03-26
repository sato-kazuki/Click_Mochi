using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ClockGadget : MonoBehaviour
{
    private float _timeElapsed;
    public TextMeshProUGUI timeText;

    private void Start()
    {
        _timeElapsed = 0;
        timeText.text = DateTime.Now.ToString("HH:mm");
    }

    private IEnumerator RepeatFunction()
    {
        while (true)
        {
            _timeElapsed += Time.deltaTime;


            if (_timeElapsed >= 60)
            {
                timeText.text = DateTime.Now.ToString("HH:mm");
                _timeElapsed = 0;
            }
            yield return null;
        }
    }
}
