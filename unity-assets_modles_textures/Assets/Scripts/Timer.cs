using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;

    public float currentTime;
    public bool countDown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnDisable()
    {
        timerText.color = Color.green;
        timerText.fontSize = 60;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        
        SetTT();
    }

    private void SetTT()
    {
        timerText.text = currentTime.ToString("0:00.00");
    }
}
