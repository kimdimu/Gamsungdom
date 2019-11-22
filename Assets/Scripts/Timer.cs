using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float LimitTime = 60;
    public Text scoreText;

    void Update()
    {
        LimitTime -= Time.deltaTime;
        scoreText.text = "남은 시간 : " + Mathf.Round(LimitTime);
    }
}
