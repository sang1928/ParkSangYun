using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer;
    Text Text;
    int _accSecond;
    public delegate void TimeCheckAction(int second);
    private TimeCheckAction _TimeCheckAction;
    public void AddTimeActionListener(TimeCheckAction listener)
    {
        _TimeCheckAction = listener;
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;_accSecond = 0;
        Text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1)
        {
            _accSecond++;
            timer = 0;
            if(_TimeCheckAction != null)
            {
                _TimeCheckAction.Invoke(_accSecond);
            }
        }
        Text.text = ($"{(5 - _accSecond).ToString()}");
    }
}
