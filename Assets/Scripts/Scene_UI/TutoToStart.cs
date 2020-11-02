using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutoToStart : MonoBehaviour
{
    private void Update()
    {
                if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("bMainScene");
            ScoreManager.Score = 0;
            CountManager.Count = 0;
        }
    }

}
