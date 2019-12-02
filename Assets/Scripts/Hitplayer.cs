using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hitplayer : MonoBehaviour
{
    public Material Red;
    public Material orange;
    public Material yellow;
    public Material green;
    public Material blue;
    public Material navy;
    public Material pupple;

    void OnTriggerEnter(Collider other)
    {

        CountManager.Count++; // 자신보다 레벨이 낮은 태그와 닿으면.

        if (CountManager.Count == 3 && CountManager.Count % 3 == 0)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = orange;
            // Destroy(other.transform);
        }
        else if (CountManager.Count == 6 && CountManager.Count % 3 == 0)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = yellow;
        }
        else if (CountManager.Count == 9 && CountManager.Count % 3 == 0)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = green;
        }
        else if (CountManager.Count == 12 && CountManager.Count % 3 == 0)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = blue;
        }
        else if (CountManager.Count == 15 && CountManager.Count % 3 == 0)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = navy;
        }
        else if (CountManager.Count == 18 && CountManager.Count % 3 == 0)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = pupple;
        }
        else if (CountManager.Count == 21 && CountManager.Count % 3 == 0)
        {
             SceneManager.LoadScene("aStartScene");
            Cursor.lockState = CursorLockMode.None;
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
        else if (other.transform.tag == "lv5")
        {
            ScoreManager.Score = ScoreManager.Score + 5;
            other.gameObject.SetActive(false);
        }
        else if (other.transform.tag == "lv6")
        {
            ScoreManager.Score = ScoreManager.Score + 6;
            other.gameObject.SetActive(false);
        }
        else if (other.transform.tag == "lv7")
        {
            ScoreManager.Score = ScoreManager.Score + 7;
            other.gameObject.SetActive(false);
        }
        else if (other.transform.tag == "lv8")
        {
            ScoreManager.Score = ScoreManager.Score + 8;
            other.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("ddd");
            other.gameObject.SetActive(false);
        }

    }
}
