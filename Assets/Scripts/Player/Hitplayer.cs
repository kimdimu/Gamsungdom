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
        if (other.transform.tag == "lv100")
        {
            Debug.Log("q");
            SceneManager.LoadScene("cOverScene");
            Cursor.lockState = CursorLockMode.None;
        }

        CountManager.Count++;

        if (CountManager.Count == 3)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = orange;
            // Destroy(other.transform);
        }
        else if (CountManager.Count == 6)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = yellow;
        }
        else if (CountManager.Count == 9)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = green;
        }
        else if (CountManager.Count == 12)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = blue;
        }
        else if (CountManager.Count == 15)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = navy;
        }
        else if (CountManager.Count == 18)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
            GameObject.Find("Fish_Model1").GetComponent<Renderer>().material = pupple;
        }
        else if (CountManager.Count == 21)
        {
            transform.localScale += new Vector3(1, 1, 1);
            transform.localPosition += new Vector3(0, 2, 0);
        }
        ///////////////////////////////////////////////
        if (other.transform.tag == "lv1")
        {
            SoundFX.instance.playSound();
            ScoreManager.Score = ScoreManager.Score + 1;
            other.gameObject.SetActive(false);
        }

        else if (other.transform.tag == "lv3")
        {
            SoundFX.instance.playSound();
            ScoreManager.Score = ScoreManager.Score + 3;
            other.gameObject.SetActive(false);
        }
        else if (other.transform.tag == "lv5")
        {
            SoundFX.instance.playSound();
            ScoreManager.Score = ScoreManager.Score + 5;
            other.gameObject.SetActive(false);
        }
        else if (other.transform.tag == "lv7")
        {
            SoundFX.instance.playSound();
            ScoreManager.Score = ScoreManager.Score + 7;
            other.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("ddd");
            other.gameObject.SetActive(false);
        }

    }
}
