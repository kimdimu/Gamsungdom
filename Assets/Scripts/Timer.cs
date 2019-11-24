using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float LimitTime = 60;
    public Text scoreText;

    void Update()
    {
        LimitTime -= Time.deltaTime;
        scoreText.text = "남은 시간 : " + Mathf.Round(LimitTime);

        if (LimitTime <= 50)
        {
            SceneManager.LoadScene("cOverScene");
        }
    }
}
