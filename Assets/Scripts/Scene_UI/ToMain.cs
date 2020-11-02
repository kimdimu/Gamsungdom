using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMain : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("aStartScene");
        ScoreManager.Score = 0;
        CountManager.Count = 0;
    }
}
