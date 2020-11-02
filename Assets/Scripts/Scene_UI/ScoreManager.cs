using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public static int Score=0;

    void Update()
    {

        ScoreText.text = "점수 : " + Mathf.Round(Score);
    }
}
