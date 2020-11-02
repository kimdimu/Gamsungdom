using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cartoon : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(NextScene());  

        IEnumerator NextScene()
        {
            yield return new WaitForSeconds(20f);   
            SceneManager.LoadScene("fOverScene");
        }
    }
}
