using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountManager : MonoBehaviour
{
    public Text CountText;
    public static int Count=0;
    
    void Update()
    {
        CountText.text = "카운트: " + Mathf.Round(Count);
    }


}
