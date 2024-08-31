using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Timer _timer;
    // Start is called before the first frame update
    void Start()
    {
        _timer.AddTimeActionListener(OnTimeSecondListener);
    }

    private void OnTimeSecondListener(int second)
    {
        if(second >= 5)
        {
            SceneManager.LoadScene(1);  
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GCWCard");
        }
    }
}
