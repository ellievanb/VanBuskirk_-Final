using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 90f;
    public GameObject lose;

    public UnityEngine.UI.Text countdownText;

    void Start()
    {
        currentTime = startingTime;
        lose.SetActive(false);
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            lose.SetActive(true);
        }
    }
}