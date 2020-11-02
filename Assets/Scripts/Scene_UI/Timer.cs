using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float LimitTime;
    public Text scoreText;

    void Update()
    {
        LimitTime -= Time.deltaTime;
        scoreText.text = "남은 시간 : " + Mathf.Round(LimitTime);

        if (LimitTime <= 0)
        {
            if (CountManager.Count >= 23)
            {
                SceneManager.LoadScene("eFinishScene");
                Cursor.lockState = CursorLockMode.None;
            }
            else
            SceneManager.LoadScene("fCartoonScene");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
