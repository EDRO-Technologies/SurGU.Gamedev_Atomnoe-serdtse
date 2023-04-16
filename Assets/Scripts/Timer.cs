using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 0f;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timeStart.ToString();
        timeStart = PlayerPrefs.GetFloat("Time");
    }

    // Update is called once per frame
    void Update()
    {
        float time = timeStart += Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();
        PlayerPrefs.SetFloat("Time", timeStart);
    }
}
