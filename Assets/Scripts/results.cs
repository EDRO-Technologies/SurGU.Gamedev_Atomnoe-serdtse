using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class results : MonoBehaviour
{
    public Text resultsText;
    public float resultTime;

    // Start is called before the first frame update
    void Start()
    {
        resultTime = PlayerPrefs.GetFloat("Time");
        resultsText.text = resultTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
