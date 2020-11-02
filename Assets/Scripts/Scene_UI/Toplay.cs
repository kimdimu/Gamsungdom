using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Toplay : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("bMainScene");
        ScoreManager.Score = 0;
        CountManager.Count = 0;
    }
}
