using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitplayer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        CountManager.Count++; // 자신보다 레벨이 낮은 태그와 닿으면.

        if (CountManager.Count % 3 == 0)
        {
            transform.localScale += new Vector3(30, 30, 30);
            // Destroy(other.transform);
        }
        else if (CountManager.Count == 49)
        {
            //
        }

        if (other.transform.tag == "lv1")
        {
            ScoreManager.Score = ScoreManager.Score + 1;
            other.gameObject.SetActive(false);
        }

        else if (other.transform.tag == "lv2")
        {
            ScoreManager.Score = ScoreManager.Score + 2;
            other.gameObject.SetActive(false);
        }
        else if (other.transform.tag == "lv3")
        {
            ScoreManager.Score = ScoreManager.Score + 3;
            other.gameObject.SetActive(false);
        }
        else if (other.transform.tag == "lv4")
        {
            ScoreManager.Score = ScoreManager.Score + 4;
            other.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("ddd");
            other.gameObject.SetActive(false);
        }

    }
}
