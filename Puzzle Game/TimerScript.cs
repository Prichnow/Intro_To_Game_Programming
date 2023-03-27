using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;
    public int second;
    public int minute;
    // Start is called before the first frame update
    void Start()
    {
        AddToSecond();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void AddToSecond()
    {
        second++;
        if (second > 59)
        {
            minute++;
            second = 0;
        }
        timeText.text = minute + ":" + second;
        Invoke(nameof(AddToSecond), 1);
    }

    public void StopTimer()
    {
        CancelInvoke(nameof(AddToSecond));
    }
}
